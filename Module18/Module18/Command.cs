using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18
{
    abstract class Command
    {
        public abstract void DownloadVideo(string videoUrl1, string path);
        public abstract void GetInfoVideo(string videoUrl1);
    }
}
