using _31_AbstractClassesAndMethods;

internal class Program
{
    public static void SekilCiz(Sekil sekil) => sekil.Ciz();
    private static void Main(string[] args)
    {

        // aşağıdaki kod hata verecektir çünkü abstract olarak tanımlanmış bir sınıftan nesne türetilemez.
        // Sekil s = new Sekil();

        Sekil s1 = new Dikdortgen();
        s1.Pozisyon.x = 50;
        s1.Pozisyon.y = 50;
        s1.Boyut.Genislik = 100;
        s1.Boyut.Yukseklik = 50;
        SekilCiz(s1);

    }
}