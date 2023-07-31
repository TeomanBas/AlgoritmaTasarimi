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
            // Klasör oluşturmak
            // Directory.CreateDirectory("dosya");
            // Klasörü silmek
            // Directory.Delete("dosya");
            // Klasör kontrolü
            // Directory.Exists("dosya");
            // Klasörün taşınması
            // Dirextory.Move("dosya");
            
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
            // dosya açmak için OpenText() metodu kullanılır.
            // StreamReader sr = File.OpenText("deneme.txt");
            // ReadLine() ile satır okuması gerçekleşir ReadLine() cursor mantığında çalışır.
            // ReadAllText() ile tüm dosya içeriğini string değişkenine alır

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
            // Dosya StreamWriter sınıfından bir nesne oluşturularak Yazma modunda açılabilir
            // StreamWriter sw = File.CreateText("deneme.txt");
            // sw.WriteLine("deneme yazısı");
            // Dosyanın içeriğinin silinmemesi ve üzerine eklenmesi için nesne File.AppendText() ile oluşturulmalıdır.
            // File.WriteAllText("deneme.txt,"deneme yazısı") metoduyla da dosya ya yazılabilir ancak içerik tamamen silinir.
            // File.AppendAllText("deneme.txt","deneme yazısı") AppendAllText metoduyla veriler son satıra eklenir .
            // dosyaya yazma işlemi yapıldıktan sonra dosya kapatılmalıdır.
            // sw.Close();
            // Bu şekilde 

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
