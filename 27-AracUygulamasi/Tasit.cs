using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_AracUygulamasi
{
    public class Tasit
    {
        public string Motor{ get; set; }
        public double Hacim { get; set; }

    }

    public enum Motor
    {
        Dizel,
        Benzin,
        LPG,
        Elektrik,
        Jet
    }
    public enum Renk
    {
        Siyah,
        Beyaz,
        Mavi,
        Kırmızı,
    }
}
