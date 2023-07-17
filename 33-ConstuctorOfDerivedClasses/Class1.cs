using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_ConstuctorOfDerivedClasses
{
    public class Dikdortgen : Sekil
    {
        public Dikdortgen()
        {
            Console.WriteLine("dikdörtgen class -> constructor");
        }

        //base class taki contructor ezilmiş oldu
        public Dikdortgen(int genislik, int yukseklik, int x, int y) : base(genislik-5, yukseklik-5, x-2, y-6)
        {
            Console.WriteLine("Derived class -> ctor - 4p");
        }

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
