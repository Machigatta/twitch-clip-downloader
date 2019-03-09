    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchClipDownloader.Classes
{
    class ClipsObject
    {
        public List<Clip> clips { get; set; }
        public string _cursor { get; set; }
    }
}
