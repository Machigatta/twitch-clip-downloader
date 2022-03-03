using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchClipDownloader.Classes
{
    class Broadcaster
    {
        public int id { get; set; }
        public string login { get; set; }
        public string display_name { get; set; }
    }

    class BroadcasterObject
    {
        public List<Broadcaster> data { get; set; }
    }
}
