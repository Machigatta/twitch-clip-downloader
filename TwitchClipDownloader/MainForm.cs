using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using TwitchClipDownloader.Classes;
using System.Text.RegularExpressions;
using System.Reflection;
using VC;

namespace TwitchClipDownloader
{
    public partial class MainForm : Form
    {
        public int downloadCounter = 0;
        private TwitchApiHandler mHandler = null;
        private SortedDictionary<string, Clip> que = new SortedDictionary<string, Clip>();
        VersionControl mvc = new VersionControl();

        public MainForm()
        {

            mHandler = new TwitchApiHandler(this);
            InitializeComponent();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            cbGame.SelectedIndex = 0;
            cbPeriod.SelectedIndex = 0;
            cbLimit.SelectedItem = "10";
            txtSave.Text = Properties.Settings.Default.savePath;
            lbVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString(2);
            txtVersion.Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString(2);
            chkAddToQue.Checked = Properties.Settings.Default.addToQue;
            chkUbs.Checked = Properties.Settings.Default.brd;
            chk_useChannel.Checked = Properties.Settings.Default.cusec;
            chk_useGame.Checked = Properties.Settings.Default.cuseg;
            checkVersionAsync();
        }

        private void saveLocals()
        {
            Properties.Settings.Default.savePath = txtSave.Text;
            Properties.Settings.Default.addToQue = chkAddToQue.Checked;
            Properties.Settings.Default.brd = chkUbs.Checked;
            Properties.Settings.Default.cusec = chk_useChannel.Checked;
            Properties.Settings.Default.cuseg = chk_useGame.Checked;
            Properties.Settings.Default.Save();
        }

        private async void checkVersionAsync()
        {
            if (await mvc.checkServerJsonAsync())
            {
                lbNewVersion.Text = "New Version Available";
            }
            else
            {
                lbNewVersion.Text = "";
            }
        }

 
        private async void bLookupTop_Click(object sender, EventArgs e)
        {
            await crawler(false);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            saveLocals();
        }

        private async void buildDownloadStringBySlug(string slug)
        {

            //is slug?
            if (slug == "" || slug.Contains("/"))
            {
                MessageBox.Show("Slug not valid.");
            }

            


            string clipUri = "https://api.twitch.tv/kraken/clips/" + slug;

            string testString = await mHandler.sendNewRequest(clipUri);

            Clip result = (Clip)JsonConvert.DeserializeObject(testString, typeof(Clip));
            if (result.slug == null)
            {
                updateLog("Nothing found.");
                txtLink.Text = "";
                txtSlug.Text = "";
                return;
            }

            if (que.ContainsKey(result.slug))
            {
                MessageBox.Show("Already in que.");
                txtLink.Text = "";
                txtSlug.Text = "";
                if (chkUbs.Checked)
                {
                    txtPre.Text = "";
                }
                return;
            }

            if (chkAddToQue.Checked)
            {
                result.pre = ( (chkUbs.Checked || txtPre.Text != "") ? ( (chkUbs.Checked) ? result.broadcaster.display_name : txtPre.Text ) : "" );
                lbQue.Items.Add(Uri.EscapeUriString((result.pre != "" ? (result.pre + "_") : "") + result.slug) + ".mp4");
                que.Add(result.slug, result);
                txtLink.Text = "";
                txtSlug.Text = "";
                if (chkUbs.Checked)
                {
                    txtPre.Text = "";
                }
            }
            else
            {
                bLookupTop.Enabled = false;
                downloadCounter++;
                if (pbDownload.Maximum == 0)
                {
                    pbDownload.Maximum = 1;
                }
                else
                {
                    pbDownload.Maximum++;
                }
                mHandler.downloadClip(result);
                txtLink.Text = "";
                txtSlug.Text = "";
            }
            
        }

        //Basic Logging function
        public void updateLog(string logContent)
        {
            rtLog.Text = logContent +"\r\n" + rtLog.Text;
            toolTipText.Text = logContent;
        }

        //Basic Logging function
        public void updateProgressBar(string action)
        {

            switch (action)
            {
                case "add":
                    pbDownload.Value++;
                    break;
                case "reset":
                    pbDownload.Value = 0;
                    pbDownload.Maximum = 0;
                    break;
                default:
                    break;
            }
        }

        public void enableButtons()
        {
            bLookupTop.Enabled = true;
        }

        private void btDownloadByLink_Click(object sender, EventArgs e)
        {
            if(txtLink.Text != "")
            {
                Match myMatch = Regex.Match(txtLink.Text, "[^/]+$");
                if (myMatch.Success)
                {
                    buildDownloadStringBySlug(myMatch.Value);
                }
                else
                {
                    MessageBox.Show("Link not valid.");
                }
            }
            else if (txtLink.Text == "" && txtSlug.Text != "")
            {
                buildDownloadStringBySlug(txtSlug.Text);
            }else
            {
                MessageBox.Show("Link or Slug missing.");
            }
            
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveLocals();
        }

        private void chkUseBroadcasterAsPre_CheckedChanged(object sender, EventArgs e)
        {
            //saveLocals();
        }

        private void chkAddToQue_CheckedChanged(object sender, EventArgs e)
        {
            btDownloadByLink.Text = (chkAddToQue.Checked ? "Add" : "Download");
            //saveLocals();
        }

        private void btStartDownloadQue_Click_1(object sender, EventArgs e)
        {

            foreach (KeyValuePair<string, Clip> pair in que)
            {
                downloadCounter++;
                if (pbDownload.Maximum == 0)
                {
                    pbDownload.Maximum = 1;
                }
                else
                {
                    pbDownload.Maximum++;
                }
                mHandler.downloadClip(pair.Value);
                
                lbQue.Items.Remove(Uri.EscapeUriString((pair.Value.pre != "" ? (pair.Value.pre + "_") : "") + pair.Value.slug) + ".mp4");
            }

            que.Clear();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region MOVABLEBIND

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        #endregion

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btLfSavePath_Click(object sender, EventArgs e)
        {
            fdb_SavePath.SelectedPath = txtSave.Text;
            DialogResult ds = fdb_SavePath.ShowDialog();
            if (ds == DialogResult.OK)
            {
                txtSave.Text = fdb_SavePath.SelectedPath + "\\";
                saveLocals();
            }
            
        }

        private async void btLookUpTopOnly_Click(object sender, EventArgs e)
        {
            await crawler(true);
        }

        private async Task crawler(bool topOnly)
        {
            string baseUrl = "https://api.twitch.tv/kraken/clips/top?limit=100";

            //wird nur gecrawled wenn spiel angegeben
            if (
                (cbGame.Text != "" && chk_useGame.Checked == true) ||
                (txtChannel.Text != "" && chk_useChannel.Checked == true) ||
                topOnly
                )
            {
                //channel speziefisch
                if (cbGame.Text != "" && chk_useGame.Checked == true && !topOnly)
                {
                    baseUrl += "&game=" + cbGame.Text;
                }

                //periode setzen (week ist default)
                if (cbPeriod.Text != "")
                {
                    baseUrl += "&period=" + cbPeriod.Text;
                }

                //channel speziefisch
                if (txtChannel.Text != "" && chk_useChannel.Checked == true && !topOnly)
                {
                    baseUrl += "&channel=" + txtChannel.Text;
                }

                //trending ist default auf false
                if (ckTrend.Checked)
                {
                    baseUrl += "&trending=true";
                }

                //trending ist default auf false
                if (txtLanguage.Text != "")
                {
                    baseUrl += "&language=" + txtLanguage.Text;
                }

                //trending ist default auf false
                if (cbLimit.Text != "")
                {
                    baseUrl += "&limit=" + cbLimit.Text;
                }

                baseUrl = Uri.EscapeUriString(baseUrl);

                updateLog("REQUEST TO: " + baseUrl);
                string testString = await mHandler.sendNewRequest(baseUrl);

                ClipsObject result = (ClipsObject)JsonConvert.DeserializeObject(testString, typeof(ClipsObject));
                if (result.clips == null)
                {
                    updateLog("Nothing found.");
                    return;
                }

                bLookupTop.Enabled = false;

                //each clip -> log it
                foreach (Clip item in result.clips)
                {

                    bool isValidForDownload = false;

                    if (sTime.Text != "")
                    {
                        if (DateTime.Now < item.created_at.AddHours(Int32.Parse(sTime.Text)))
                        {
                            isValidForDownload = true;
                        }

                    }
                    else
                    {
                        isValidForDownload = true;

                    }

                    if (isValidForDownload)
                    {
                        downloadCounter++;
                        mHandler.downloadClip(item);
                    }

                }

                if (downloadCounter == 0)
                {
                    bLookupTop.Enabled = true;
                    updateLog("---- Could not find any clips ----");
                }
                else
                {
                    updateLog("---- Starting " + downloadCounter + " Downloads ----");
                    pbDownload.Maximum = downloadCounter;
                }

            }
            else if (chk_useGame.Checked == false && chk_useChannel.Checked == false)
            {
                updateLog("At least one of the checkboxes of usage must be checked.");
            }
            else
            {
                updateLog("There must be at least a game or channel name given.");
            }
        }

        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            saveLocals();
        }

        private void versionTimer_TickAsync(object sender, EventArgs e)
        {
            checkVersionAsync();
        }
    }
}