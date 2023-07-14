using System;
//Stream nesneleri kullanabilmek System.IO library sini eklemek gerek.
using System.IO;
using System.Text;
using _25_DosyaIslemleri;

internal class Program
{
    private static void Main(string[] args)
    {
        
        // dosya kopyalamak için dizinler 
        FILE_ISLEMLERI filenesne = new FILE_ISLEMLERI();
        string kaynak= filenesne.FizikselYol("deneme.txt");
        string hedef = filenesne.FizikselYol("deneme_kopyası.txt");
        //DosyaKopyala(kaynak,hedef);
        DosyaSil(hedef);
        DosyaSil(kaynak);
        


    }
    public static void FileStreamUygulamasi()
    {
        FILE_ISLEMLERI dosyayol = new FILE_ISLEMLERI();
        //string dosyayolu=dosyayol.FizikselYol("deneme.txt");
        //Console.WriteLine(dosyayolu);
        string dizin = dosyayol.FizikselYol("deneme.txt");
        try
        {
            string ad = "";
            FileStream fs = new FileStream(dizin, FileMode.Append, FileAccess.Write, FileShare.None);
            while (ad != "cikis")
            {
                Console.WriteLine("\n Dosyaya kaydetmek için isim giriniz");
                ad = Console.ReadLine();
                if (ad != "cikis")
                {
                    if (fs.CanWrite)
                    {
                        byte[] yaz = Encoding.UTF8.GetBytes(ad);
                        fs.Write(yaz, 0, yaz.Length);
                        fs.WriteByte(13);
                    }
                    else
                    {
                        Console.WriteLine("yazma yetkiniz yok");
                    }
                }
            }
            //dosya kapatılmassa kayıtlar dosyaya yazılmamış olur
            fs.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
    public static void FileInfoDosyaBilgileri()
    {
        FILE_ISLEMLERI dosyayol = new FILE_ISLEMLERI();
        string dizin = dosyayol.FizikselYol("deneme.txt");
        var fi = new FileInfo(dizin);
        Console.WriteLine(fi.FullName);
        Console.WriteLine(fi.Length);
        Console.WriteLine(fi.Extension);
        Console.WriteLine(fi.CreationTime);
        Console.WriteLine(fi.CreationTimeUtc);
        Console.WriteLine(fi.LastWriteTime);
        Console.WriteLine(fi.Name);
    }
    public static void DosyaKopyala(string kaynak,string hedef)
    {
        FileInfo fi = new FileInfo(kaynak);
        fi.CopyTo(hedef);
        Console.WriteLine("{0} dosyası {1} adında kopyalandı",kaynak,hedef);
    }
    public static void DosyaSil(string kaynak)
    {
       
        try
        {
            FileInfo fi = new FileInfo(kaynak);
            fi.Delete();
        }catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
    }
    
}