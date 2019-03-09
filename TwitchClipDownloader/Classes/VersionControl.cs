using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace VC
{
    class VersionControl
    {
        private string hashedVersion = GetMd5Hash(Assembly.GetExecutingAssembly().GetName().Version.ToString(2));
        private string hashedApplication = GetMd5Hash("TwitchClipDownloader");
        private string homepage = "https://machigatta.com/projects.json";
        public VersionControl()
        {

        }

        public async Task<bool> checkServerJsonAsync()
        {
            if (this.checkInternetConnection())
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage()
                {
                    RequestUri = new Uri(homepage),
                    Method = HttpMethod.Get,
                };
                var req = await client.SendAsync(request);

                ServerJson result = (ServerJson)JsonConvert.DeserializeObject(await req.Content.ReadAsStringAsync(), typeof(ServerJson));
                foreach (var item in (JObject)result.check)
                {
                    if (item.Key == hashedApplication)
                    {
                        Debug.Print(item.Value.Value<string>());
                        if (item.Value.Value<string>() != hashedVersion)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        private static string GetMd5Hash(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
                return sBuilder.ToString();
            }
            
        }

        private bool checkInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead(this.homepage))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }

    class ServerJson
    {
        public object check { get; set; }
    }
}
