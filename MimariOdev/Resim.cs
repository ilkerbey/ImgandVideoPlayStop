using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MimariOdev
{
    class Resim:IPlayer
    {
        public string Ad { get; set; }
        public string RenkDagilimi { get; set; }
        public string ResmiCeken { get; set; }
        public string Play()
        {
            return "Resim Gösterisi Oynatılıyor";
        }

        public string Stop()
        {
            return "Resim Gösterisi Duruduruldu";
        }


    }
}
