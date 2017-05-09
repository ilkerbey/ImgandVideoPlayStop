using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MimariOdev
{
    public class Video:IPlayer
    {
        public string Ad { get; set; }
        public uint Sure { get; set; }
        public float ImdbPuani { get; set; }
        public string Play()
        {
            return "Video Oynatiliyor";
        }

        public string Stop()
        {
            return "Video Durduruldu";
        }

    }
}
