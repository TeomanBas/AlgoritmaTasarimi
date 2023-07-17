using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_AracUygulamasi
{
    public class Arac : Tasit
    {
        #region fields
        private string marka, model, renk;
        private int yil;
        #endregion

        #region properties
        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public string Renk { get => renk; set => renk = value; }
        public int Yil { get => yil; set => yil = value; }
        #endregion

        #region constructor
        public Arac()
        {
            
        }

        public Arac(string marka,string model,string renk,int yil)
        {
            Marka= marka;
            Model= model;
            Renk= renk;
            Yil= yil;
        }
        #endregion

        #region methods
        public static void Calistir()
        {
            Console.WriteLine("araç çalıştı");
        }
        
        public static void Durdur()
        {
            Console.WriteLine("araç durdu");
        }

        // ToString() metodu tüm class lara varsayılan olarak gelir çünkü herşey bir objeden türediği yani yani classlarda herzaman ToString() metodu vardır.
        public override string? ToString()
        {
            //base ust sınıf yani Tasit sınıfını kasteder
            // return base.ToString();

            Console.WriteLine($"{Marka}");
            Console.WriteLine($"{Model}");
            Console.WriteLine($"{Renk}");
            Console.WriteLine($"{Yil}");
            Console.WriteLine($"{Hacim}");
            Console.WriteLine($"{Motor}");
            Console.WriteLine(new string('-',59));
            return "";
        }
        #endregion


    }
}
