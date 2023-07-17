using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_CallingBaseVersionOfMethods
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
    }
}
