using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchClipDownloader.Classes
{
    class GameObject
    {
        public List<GameSingle> data { get; set; }
        public Pagination pagination { get; set; }
    }

    class GameSingle
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
