﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchClipDownloader.Classes
{
    class ClipsObject
    {
        public List<Clip> data { get; set; }
        public Pagination pagination { get; set; }
    }
}
