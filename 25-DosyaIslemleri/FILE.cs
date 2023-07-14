using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_DosyaIslemleri
{
    internal class FILE_ISLEMLERI
    {
        public string FizikselYol(string dosyaad)
        {
            // dinamik yol tanımı
            string[] yol = Directory.GetCurrentDirectory().Split('\\');
            string dosyayol = "";
            for (int i = 0; i < yol.Length - 3; i++)
            {
                dosyayol += yol[i] + "\\";
            }
            dosyayol += dosyaad;
            return dosyayol;
        }
        public static void DosyaOkuma()
        {
            try
            {
                //dinamik konum: length değerinden -3 eleman çıkartılmasaydı exe dosyasının çalıştığı dizini işaret edecekti.
                string[] yol = Directory.GetCurrentDirectory().Split("\\");
                string dosyayol = "";
                for (int i = 0; i < yol.Length - 3; i++)
                {
                    dosyayol += yol[i] + "\\";
                }
                dosyayol += "rakamlar.txt";
                // dosya okuma ve yazma
                //using eğer kod bloglarının içerisinde kullanılırsa içerisindeki kodların çalışırken kullanıdğı kaynakları çalışma bitiminde serbest bırakır.
                using (StreamReader sr = new StreamReader(dosyayol))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void DosyaYazma()
        {
            try
            {
                // dinamik yol tanımı
                string[] yol = Directory.GetCurrentDirectory().Split('\\');
                string dosyayol = "";
                for (int i = 0; i < yol.Length - 3; i++)
                {
                    dosyayol += yol[i] + "\\";
                }
                dosyayol += "adlar.txt";
                string[] adlar = new string[] { "mike", "tom", "diamon", "richert", "alice", "bob" };
                using (StreamWriter sw = new StreamWriter(dosyayol))
                {
                    foreach (string line in adlar)
                    {
                        sw.WriteLine(line);

                    }
                    Console.WriteLine("\n adlar.txt dosyası başarılı bir şekilde oluşturuldu.");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("hata");
            }
        }
    }
}
