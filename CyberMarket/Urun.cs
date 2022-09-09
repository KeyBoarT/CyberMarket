using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberMarket
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public decimal UrunFiyati { get; set; }
        public int UrunAdedi { get; set; }
        public string UrunSinifi { get; set; }
        public byte[] UrunResmi { get; set; }
    }
}
