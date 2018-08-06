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

namespace TwitchClipDownloader
{
    public partial class MainForm : Form
    {
        public int downloadCounter = 0;
        private TwitchApiHandler mHandler = null;
        public MainForm()
        {

            mHandler = new TwitchApiHandler(this);
            InitializeComponent();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            cbGame.SelectedIndex = 0;
            cbPeriod.SelectedIndex = 0;
            cbLimit.SelectedItem = "10";
            txtSave.Text = Properties.Settings.Default.savePath;
            lbVersion.Text = this.ProductVersion.ToString();
        }

 
        private async void bLookupTop_Click(object sender, EventArgs e)
        {
            string baseUrl = "https://api.twitch.tv/kraken/clips/top?limit=100";
            string downloadUri = "";

            //wird nur gecrawled wenn spiel angegeben
            if (cbGame.Text != "")
            {
                baseUrl += "&game=" + cbGame.Text;

                //periode setzen (week ist default)
                if (cbPeriod.Text != "")
                {
                    baseUrl += "&period=" + cbPeriod.Text;
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

                ClipsObject result = (ClipsObject)JsonConvert.DeserializeObject(testString,typeof(ClipsObject));
                if (result.clips == null)
                {
                    updateLog("Nothing found.");
                    return;
                }

                bLookupTop.Enabled = false;

                //each clip -> log it
                foreach (Clip item in result.clips)
                {
                    downloadCounter++;
                    mHandler.downloadClip(item);
                }

                updateLog("---- Starting " + downloadCounter + " Downloads ----");
                pbDownload.Maximum = downloadCounter;
            }
            else
            {
                updateLog("Kein Spiel angegeben");
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.savePath = txtSave.Text;
            Properties.Settings.Default.Save();
        }

        private void btDownloadBySlug_Click(object sender, EventArgs e)
        {
            buildDownloadStringBySlug(txtSlug.Text);
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
            if (result == null)
            {
                updateLog("Nothing found.");
                return;
            }

            bLookupTop.Enabled = false;
            downloadCounter++;
            if (pbDownload.Maximum == 0)
            {
                pbDownload.Maximum = 1;
            }else
            {
                pbDownload.Maximum++;
            }
            mHandler.downloadClip(result);
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

    }
      
}