using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_TekCift_Uygulamasi
{
    public class TekCift
    {
        public static bool Tek(int n)
        {
            if (n % 2 == 1)
            {
                return true;
            }
            return false;
        }
        public static bool Cift(int n)
        {
            if ((n % 2) == 0)
            {
                return true;
            }
            return false;
        }
    }
}
