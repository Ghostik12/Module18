using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18
{
    class ConcreteCommand : Command
    {
        Receiver _receiver;

        public ConcreteCommand(Receiver receiver)
        {
            _receiver = receiver;
        }
        public override async void DownloadVideo(string videoUrl1, string path)
        {
            _receiver.Download(videoUrl1, path);
        }

        public override void GetInfoVideo(string videoUrl1)
        {
            _receiver.InfoVideo(videoUrl1);
        }
    }
}
