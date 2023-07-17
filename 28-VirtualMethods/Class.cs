using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_VirtualMethods
{
    public  class Pozisyon
    {
        public int x { get; set; }
        public int y { get; set; }

        public override string ToString() => $" x : {x}, y: {y}";

    }
    public class Boyut
    {
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }
        public override string ToString()
        {
            return $"Genislik : {Genislik}" +
                $"Yukseklik : {Yukseklik}";
        }
    }
    public class Sekil
    {
        public Pozisyon Pozisyon { get; }= new Pozisyon();
        public Boyut Boyut { get; }= new Boyut();
        public virtual void Ciz() => Console.WriteLine($"Sekil {Pozisyon} - {Boyut}");
    }
}
