using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchClipDownloader.Classes
{
    class Clip
    {
        public string id { get; set; }
        public string broadcaster_id { get; set; }
        public string broadcaster_name { get; set; }
        public string language { get; set; }
        public DateTime created_at { get; set; }
        public int view_count { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnail_url { get; set; }
        public string syntaxed_name { get; set; }

        //custom
        public string pre { get; set; }
    }
}
