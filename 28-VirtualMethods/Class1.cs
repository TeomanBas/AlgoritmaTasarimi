using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_VirtualMethods
{
    public class Dikdortgen : Sekil
    {
        public override void Ciz()
        {
            // base türetildiği sınıftaki metodu kasteder.
            // base.Ciz();
            Console.WriteLine($"dikdörtgen {Pozisyon} - {Boyut}");
        }
    }
}
