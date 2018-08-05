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

namespace TwitchClipDownloader
{
    public partial class Form1 : Form
    {
        private int downloadCounter = 0;
        public Form1()
        {
            InitializeComponent();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            cbGame.SelectedIndex = 0;
            cbPeriod.SelectedIndex = 0;
            txtSave.Text = Properties.Settings.Default.savePath;
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

                baseUrl = Uri.EscapeUriString(baseUrl);

                rtLog.Text = "REQUEST TO: " + baseUrl + "\r\n" + rtLog.Text;

                var client = new HttpClient();
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(baseUrl),
                    Method = HttpMethod.Get,
                };

                request.Headers.Add("client-id", "h91ejo3shtecvixy0xhcd6mulvitd8");
                request.Headers.Add("accept", "application/vnd.twitchtv.v5+json");
                var req = await client.SendAsync(request);

                string testString = await req.Content.ReadAsStringAsync();

                ClipsObject result = (ClipsObject)JsonConvert.DeserializeObject(testString,typeof(ClipsObject));
                if (result.clips == null)
                {
                    rtLog.Text = "Nothing found.\r\n" + rtLog.Text;
                    return;
                }


                bLookupTop.Enabled = false;

                //each clip -> log it
                foreach (Clip item in result.clips)
                {

                    downloadUri = item.thumbnails.medium.Replace("-preview-480x272.jpg", ".mp4");
                    using (WebClient wc = new WebClient())
                    {

                        downloadCounter++;
                        wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
                        string fileName = Uri.EscapeUriString(item.broadcaster.display_name + "_" + item.slug);
                        wc.DownloadFileAsync(new System.Uri(@downloadUri),Properties.Settings.Default.savePath.Replace("\\", "\\\\") + fileName + ".mp4");

                        rtLog.Text = "---- " + downloadUri + " ----\r\n" + rtLog.Text;
                    }

                    
                }

                rtLog.Text = "---- Starting " + downloadCounter + " Downloads ----\r\n" + rtLog.Text;
                pbDownload.Maximum = downloadCounter;
            }
            else
            {
                rtLog.Text = "Kein Spiel angegeben\r\n" + rtLog.Text;
            }
        }

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                rtLog.Text = e.Error.InnerException.Message + "\r\n" + rtLog.Text;
            }
            
            downloadCounter--;
            pbDownload.Value++;

            if (downloadCounter == 0)
            {
                rtLog.Text = "---- All downloads finished ----\r\n" + rtLog.Text;
                bLookupTop.Enabled = true;
                pbDownload.Value = 0;
            }
            else
            {
                
                rtLog.Text = "Downloads left: " + downloadCounter + "\r\n" + rtLog.Text;
            }
            
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.savePath = txtSave.Text;
            Properties.Settings.Default.Save();
        }
    }
      
}




public class ClipsObject
{
    public List<Clip> clips { get; set; }
}

public class Clip
{
    public string slug { get; set; }
    public broadcaster broadcaster { get; set; }
    public string title { get; set; }
    public thumbnails thumbnails { get; set; }
}

public class thumbnails
{
    public string medium { get; set; }
}

public class broadcaster
{
    public string display_name { get; set; }
}

