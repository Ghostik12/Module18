using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18
{
    class Sender
    {
        Command _command;
        public void SetCommand(Command command)
        {
            _command = command;
        }

        public void Start(string videoUrl1, string path)
        {
            _command.DownloadVideo(videoUrl1, path);
        }

        public void Info(string videoUrl1)
        {
            _command.GetInfoVideo(videoUrl1);
        }
    }
}
