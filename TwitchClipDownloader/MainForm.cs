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
using System.Globalization;

namespace TwitchClipDownloader
{
    public partial class MainForm : Form
    {
        public int downloadCounter = 0;
        private TwitchApiHandler mHandler = null;
        private SortedDictionary<string, Clip> que = new SortedDictionary<string, Clip>();
        VersionControl mvc = new VersionControl();
        private List<GameSingle> t = new List<GameSingle>();
        private List<Clip> c = new List<Clip>();
        private Broadcaster b = new Broadcaster();

        public MainForm()
        {

            mHandler = new TwitchApiHandler(this);
            InitializeComponent();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            txtSave.Text = Properties.Settings.Default.savePath;
            lbVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString(2);
            txtVersion.Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString(2);
            chkAddToQue.Checked = Properties.Settings.Default.addToQue;
            chkUbs.Checked = Properties.Settings.Default.brd;

            txtClientId.Text = Properties.Settings.Default.twitchClientId;
            txtClientSecret.Text = Properties.Settings.Default.twitchClientSecret;

            checkVersionAsync();
            Task task = LoadGamesAsync();
        }

        private void saveLocals()
        {
            Properties.Settings.Default.savePath = txtSave.Text;
            Properties.Settings.Default.addToQue = chkAddToQue.Checked;
            Properties.Settings.Default.brd = chkUbs.Checked;
            Properties.Settings.Default.twitchClientId = txtClientId.Text;
            Properties.Settings.Default.twitchClientSecret = txtClientSecret.Text;
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
            b = await TryToGetBroadcasterID(txtChannel.Text.ToLower());
            await crawler();
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

            


            string clipUri = "https://api.twitch.tv/helix/clips?id=" + slug;

            string testString = await mHandler.sendNewRequest(clipUri);

            ClipsObject result = (ClipsObject)JsonConvert.DeserializeObject(testString, typeof(ClipsObject));
            if (result.data == null)
            {
                updateLog("Nothing found.");
                txtLink.Text = "";
                txtSlug.Text = "";
                return;
            }

            Clip c = result.data[0];
            if (que.ContainsKey(c.id))
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
                c.pre = ( (chkUbs.Checked || txtPre.Text != "") ? ( (chkUbs.Checked) ? c.broadcaster_name : txtPre.Text ) : "" );
                lbQue.Items.Add(Uri.EscapeUriString((c.pre != "" ? (c.pre + "_") : "") + c.id) + ".mp4");
                que.Add(c.id, c);
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
                mHandler.downloadClip(c);
                txtLink.Text = "";
                txtSlug.Text = "";
            }
            
        }

        //Basic Logging function
        public void updateLog(string logContent, bool forContext = true)
        {
            rtLog.Text = logContent +"\r\n" + rtLog.Text;
            if (forContext)
            {
                toolTipText.Text = logContent;
            }
        }

        public void updateLogDetailed(string logContent, bool forContext = true)
        {
            rtLogDetailed.Text = logContent + "\r\n" + rtLogDetailed.Text;
            if (forContext)
            {
                toolTipText.Text = logContent;
            }
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

        private async Task LoadGamesAsync(string cursor = "")
        {
            if (t.Count > 50)
            {
                cbGame.DataSource = t;
                cbGame.DisplayMember = "name";
                updateLog("FINISHED CRAWLING GAMES");
                return;
            }
            string baseUrl = "https://api.twitch.tv/helix/games/top?first=100";
            if (cursor != "")
            {
                baseUrl += "&after=" + cursor;
            }

            baseUrl = Uri.EscapeUriString(baseUrl);
            updateLog("CRAWLING GAMES");
            updateLog("REQUEST TO: " + baseUrl, false);
            string testString = await mHandler.sendNewRequest(baseUrl);
            GameObject result = (GameObject)JsonConvert.DeserializeObject(testString, typeof(GameObject));

            if (result.data == null)
            {
                updateLog("Nothing found.");
                return;
            }

            t.Add(new GameSingle());
            foreach (GameSingle item in result.data)
            {
                updateLogDetailed("Adding Game: " + item.name, false);
                t.Add(item);
            }

            if (result.pagination.cursor != "" && result.pagination.cursor != cursor)
            {
                await LoadGamesAsync(result.pagination.cursor);
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
                
                lbQue.Items.Remove(Uri.EscapeUriString((pair.Value.pre != "" ? (pair.Value.pre + "_") : "") + pair.Value.id) + ".mp4");
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

        private async Task<Broadcaster> TryToGetBroadcasterID(string login)
        {
            string baseUrl = "https://api.twitch.tv/helix/users?login="+login;
            baseUrl = Uri.EscapeUriString(baseUrl);
            updateLog("LOOKING FOR USER: " + login);
            string testString = await mHandler.sendNewRequest(baseUrl);
            BroadcasterObject resultO = (BroadcasterObject)JsonConvert.DeserializeObject(testString, typeof(BroadcasterObject));
            if (resultO.data == null)
            {
                updateLog("Nothing found.");
                return null;
            }
            updateLog("FOUND USER: " + resultO.data[0].display_name);

            return resultO.data[0];
        }

        private async Task crawler(string cursor = "")
        {
            string baseUrl = "https://api.twitch.tv/helix/clips?first=100";

            GameSingle gs = cbGame.SelectedItem as GameSingle;

            //wird nur gecrawled wenn spiel angegeben
            if ( (gs.id != 0) || (txtChannel.Text != "") )
            {
                //channel speziefisch
                if (gs.id != 0)
                {
                    baseUrl += "&game_id=" + gs.id;
                }

                //channel speziefisch
                if (txtChannel.Text != "")
                {
                    baseUrl += "&broadcaster_id=" + b.id;
                }

                baseUrl += "&started_at=" + dtFrom.Value.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'", DateTimeFormatInfo.InvariantInfo);
                baseUrl += "&ended_at=" + dtTo.Value.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'", DateTimeFormatInfo.InvariantInfo);

                if (cursor != "")
                {
                    baseUrl += "&cursor=" + cursor;
                }

                baseUrl = Uri.EscapeUriString(baseUrl);

                updateLog("REQUEST TO: " + baseUrl, false);
                string testString = await mHandler.sendNewRequest(baseUrl);

                ClipsObject result = (ClipsObject)JsonConvert.DeserializeObject(testString, typeof(ClipsObject));
                if (result.data == null)
                {
                    updateLog("Nothing found.");
                    return;
                }

                updateLog("CLIPS FOUND: " + result.data.Count, false);

                //each clip -> log it
                foreach (Clip item in result.data)
                {
                    bool isValidForDownload = true;
                    bool wrongLanguage = true;

                    foreach (string l in txtLanguage.Text.Split(','))
                    {
                        if (l == item.language)
                        {
                            wrongLanguage = false;
                        }
                    }

                    if (wrongLanguage)
                    {
                        isValidForDownload = false;
                    }

                    if (item.created_at > dtTo.Value || item.created_at < dtFrom.Value)
                    {
                        isValidForDownload = false;
                    }

                    if (isValidForDownload && c.Count <= numLimit.Value)
                    {
                        downloadCounter++;
                        updateLogDetailed("Found Clip: " + item.id, false);
                        c.Add(item);
                        mHandler.downloadClip(item);
                    }
                }

                if (result.pagination.cursor != "" && result.pagination.cursor != cursor)
                {
                    await crawler(result.pagination.cursor);
                }
                else
                {
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
            }
            else
            {
                updateLog("There must be at least a game or channel name given.");
            }
        }

        public void clearSavedCLips()
        {
            c.Clear();
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