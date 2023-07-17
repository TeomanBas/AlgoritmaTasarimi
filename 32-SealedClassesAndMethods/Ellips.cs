using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_SealedClassesAndMethods
{
    public class Ellips : Sekil
    {
        /*
        new public void Tasi(int x,int y)
        {
            Pozisyon.x += x;
            Pozisyon.y += y;
        }
        */
        public override void Tasi(Pozisyon yenipozisyon)
        {
            base.Tasi(yenipozisyon);
        }

        public override void YenidenBoyutlandir(int genislik, int yukseklik)
        {
            throw new NotImplementedException();
        }
    }
}
