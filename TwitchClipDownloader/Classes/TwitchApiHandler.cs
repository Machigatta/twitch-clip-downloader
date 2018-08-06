using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TwitchClipDownloader.Classes
{
    class TwitchApiHandler
    {
        private MainForm form = null;
        public TwitchApiHandler(MainForm activeForm)
        {
            form = activeForm;
        }

        public async Task<string> sendNewRequest(string url)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage()
            {
                RequestUri = new Uri(url),
                Method = HttpMethod.Get,
            };

            request.Headers.Add("client-id", Properties.Settings.Default.twitchClientId);
            request.Headers.Add("accept", "application/vnd.twitchtv.v5+json");
            var req = await client.SendAsync(request);

            return await req.Content.ReadAsStringAsync();
            
        }

        public void downloadClip(Clip item)
        {
            string downloadUri = item.thumbnails.medium.Replace("-preview-480x272.jpg", ".mp4");

            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
                string fileName = Uri.EscapeUriString(item.broadcaster.display_name + "_" + item.slug);
                wc.DownloadFileAsync(new System.Uri(@downloadUri), Properties.Settings.Default.savePath.Replace("\\", "\\\\") + fileName + ".mp4");

                form.updateLog("---- " + downloadUri + " ----");
            }

        }


        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                form.updateLog(e.Error.InnerException.Message);
            }

            form.downloadCounter--;
            form.updateProgressBar("add");

            if (form.downloadCounter == 0)
            {
                form.updateLog("---- All downloads finished ----");
                form.enableButtons();
                form.updateProgressBar("reset");
            }
            else
            {

                form.updateLog("Downloads left: " + form.downloadCounter);
            }

        }
    }
}
