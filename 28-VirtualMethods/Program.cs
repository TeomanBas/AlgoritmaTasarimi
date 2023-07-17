using _28_VirtualMethods;

internal class Program
{
    private static void Main(string[] args)
    {
        var r = new Dikdortgen();
        r.Pozisyon.x = 12;
        r.Pozisyon.y = 23;
        r.Boyut.Genislik = 100;
        r.Boyut.Yukseklik = 50;
        r.Ciz();
    }
}