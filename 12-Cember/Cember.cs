using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_CemberinCevresi
{
    public class Cember
    {
        public const double pi = 3.14;

        /// <summary>
        /// çemberin çevresini verir
        /// </summary>
        /// <param name="r">yarıçaptır.</param>
        /// <returns>çemberin çevresini döndürür.</returns>
        public static double Cevresi(double r)
        {
            return 2*pi*r;
        }
        /// <summary>
        /// Dairenin alanını verir
        /// </summary>
        /// <param name="r">yarıçaptır.</param>
        /// <returns>dairenin alanın döndürür</returns>
        public static double Alani(double r)
        {
            return pi*r*r;
        }
        public static double Alani(double r, double aci)
        {
            return pi * r * r * aci/360;
        }

    }
    
}
