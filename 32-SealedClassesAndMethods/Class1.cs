using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_SealedClassesAndMethods
{
    public class Dikdortgen : Sekil
    {
        public override void Ciz()
        {
            // base türetildiği sınıftaki metodu kasteder.
            // base.Ciz();
            Console.WriteLine($"dikdörtgen {Pozisyon} - {Boyut}");
        }

        public override void YenidenBoyutlandir(int genislik, int yukseklik)
        {
            Boyut.Genislik = genislik;
            Boyut.Yukseklik = yukseklik;
            // varyılan durumda bir hata fırlatıyor.
            //throw new NotImplementedException();
        }
    }
}
