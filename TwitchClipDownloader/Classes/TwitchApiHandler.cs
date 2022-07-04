using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TwitchClipDownloader.Classes
{
    class TwitchApiHandler
    {
        private MainForm form = null;
        private AuthObject _A = null;
        public TwitchApiHandler(MainForm activeForm)
        {
            form = activeForm;
            if (Properties.Settings.Default.twitchClientId != "" && Properties.Settings.Default.twitchClientSecret != "")
            {
                getAuthToken();
            }
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
            //request.Headers.Add("accept", "application/vnd.twitchtv.v5+json");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _A.access_token);
            var req = await client.SendAsync(request);

            return await req.Content.ReadAsStringAsync();
            
        }
        
        public void downloadClip(Clip item)
        {
            string downloadUri = item.thumbnail_url.Replace("-preview-480x272.jpg", ".mp4");

            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
                string fileName = Uri.EscapeUriString( item.syntaxed_name );
                wc.DownloadFileAsync(new System.Uri(@downloadUri), Properties.Settings.Default.savePath.Replace("\\", "\\\\") + fileName + ".mp4");

                form.updateLog("---- " + downloadUri + " ----");
            }

        }

        public static async Task<AuthObject> GetAuthorizeToken()
        {
            // Initialization.  
            AuthObject a = null;
            using (var client = new HttpClient())
            {
                string test = "https://id.twitch.tv/oauth2/";
                client.BaseAddress = new Uri(test);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = new HttpResponseMessage();
                List<KeyValuePair<string, string>> allIputParams = new List<KeyValuePair<string, string>>();

                // Convert Request Params to Key Value Pair.  
                // URL Request parameters.  
                allIputParams.Add(new KeyValuePair<string, string>("client_id", Properties.Settings.Default.twitchClientId));
                allIputParams.Add(new KeyValuePair<string, string>("client_secret", Properties.Settings.Default.twitchClientSecret));
                allIputParams.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
                HttpContent requestParams = new FormUrlEncodedContent(allIputParams);

                // HTTP POST  
                response = await client.PostAsync("token", requestParams).ConfigureAwait(false);

                // Verification  
                if (response.IsSuccessStatusCode)
                {
                    a = JsonConvert.DeserializeObject<AuthObject>(await response.Content.ReadAsStringAsync());
                    // Reading Response.  
                }
            }

            return a;
        }

        public void getAuthToken()
        {
            _A = GetAuthorizeToken().Result;
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
                form.clearSavedCLips();
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
