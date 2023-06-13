namespace Sabitler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // const ile tanımlanan değişkenler sonradan değiştirilemez access modifier ile kullanılamaz.
            // sabitlere oluşturulduğu yerde değeri verilmelidir. const yapısı için sonradan değer verilemez
            const double pi = 3.1428;
            const int x1 = 5;
            int x2 = 10;
            // burada pi sayısının yerine 5 gibi bir değer yazarsak hata almayız.ancak sabit olmayan bir değişken yazılırsa hata alınır
            // bunun sebebi sabitlerin ancak sabitler ile işleme tutulacağıdır.
            const int c1 = 3 + x1 + (int)pi;
            // alt satırdaki kodlar çalışmaz
            //const int c1 = 44 + x1;



            var sinif1 = new OrnekSinif(111, 222);

            Console.WriteLine($"x = {sinif1.x} , y ={sinif1.y}");

            // aşağıdaki kod hata  verecektir OrnekSinif içerisine tanımladığımız const değişkenleri static bir yapıdadır 
            // bunlara tanımladığımız nesne üzerinden ulaşamayız ancak sınıf üzerinden ulaşabiliriz.
            //Console.WriteLine($"C2 = {sinif1.c1} , C2 = {sinif1.c2}");

            // sınıf içerisindeki static yapılara sınıf üzerinden ulaşılabilir.
            Console.WriteLine($"c1 = {OrnekSinif.c1} , c2 ={OrnekSinif.c2}");


        }
        /* eğer sabite ihtiyacımız var ancak değerini sonradan vermemiz gerekiyorsa readonly kullanılmalıdır.
            readonly yi yapılandırıcı bir sınıf içerisinde kullanabiliriz main metodu içerisinde kullanamayız.
            */
        // örnek bir readonly tanımlaması
        readonly int r1;
        public Program()
        {
            r1 = 3;
        }

    }

    // örnek bir class tanımı
    class OrnekSinif
    {
        public int x;
        public int y;

        public const int c1 = 5;
        public const int c2 = c1 + 5;

        public OrnekSinif(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

}

