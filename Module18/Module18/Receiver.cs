using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Search;
using YoutubeExplode.Videos;

namespace Module18
{
    class Receiver
    {
        public async void Download(string videoUrl1, string path) 
        {
            var client = new YoutubeClient();
            await client.Videos.DownloadAsync(videoUrl1, path, builder => builder.SetPreset(ConversionPreset.UltraFast));
        }

        public void InfoVideo(string videoUrl1)
        {
            var client = new YoutubeClient();
            var videoInfo = client.Videos.GetAsync(videoUrl1);
            Console.WriteLine(videoInfo);
        }
    }
}
