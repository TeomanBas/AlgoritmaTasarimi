using _27_AracUygulamasi;
internal class Program
{
    private static void Main(string[] args)
    {
        Arac aracim = new Arac("volvo", "superb", "gri", 2023)
        {
            Hacim = 3.14,
            Motor = Motor.Benzin.ToString()
        };
        aracim.ToString();
        Console.WriteLine(new string('-',59));
        // list<T> yapısı ile arac sınıfının kullanımı
        List<Arac> filo = new List<Arac>();

        filo.Add(new Arac { Marka ="skoda",
        Model= "octavia",
        Renk = Renk.Kırmızı.ToString(),
        Yil = 2018,
        Motor = Motor.Dizel.ToString(),
        Hacim = 1.6});

        filo.Add(new Arac
        {
            Marka = "opel",
            Model = "carsa",
            Renk = Renk.Beyaz.ToString(),
            Yil = 2019,
            Motor = Motor.Benzin.ToString(),
            Hacim = 1.5
        });

        filo.Add(new Arac
        {
            Marka = "fiat",
            Model = "fiarino",
            Renk = Renk.Mavi.ToString(),
            Yil = 2014,
            Motor = Motor.Benzin.ToString(),
            Hacim = 1.9
        });

        foreach (Arac item in filo)
            item.ToString();


    }
}