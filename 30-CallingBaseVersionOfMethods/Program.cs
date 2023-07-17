using _30_CallingBaseVersionOfMethods;
internal class Program
{
    public static void SekilCiz(Sekil sekil) => sekil.Ciz();
    private static void Main(string[] args)
    {
        var r = new Ellips();
        r.Pozisyon.x = 12;
        r.Pozisyon.y = 23;
        r.Boyut.Genislik = 100;
        r.Boyut.Yukseklik = 50;
        SekilCiz(r);
        r.Tasi(new Pozisyon { x=20, y=30});
        SekilCiz(r);

    }
}