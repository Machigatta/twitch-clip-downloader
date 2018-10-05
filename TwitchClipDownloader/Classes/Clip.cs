using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchClipDownloader.Classes
{
    class Clip
    {
        public string slug { get; set; }
        public Broadcaster broadcaster { get; set; }
        public string title { get; set; }
        public Thumbnails thumbnails { get; set; }
        public DateTime created_at { get; set; }
    }
}
