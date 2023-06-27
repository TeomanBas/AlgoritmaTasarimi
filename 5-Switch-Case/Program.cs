internal class Program
{
    public enum Renkler { Kirmizi, Yesil, Mavi }
    private static void Main(string[] args)
    {
        Console.WriteLine("UYGULAMA 1-------------------------------------------------------------------");

        Renkler r = (Renkler)(new Random()).Next(0,10);

        switch (r)
        {
            case Renkler.Kirmizi:
                Console.WriteLine("kirmizi");
                break;
            case Renkler.Yesil:
                Console.WriteLine("yeşil");
                break;
            case Renkler.Mavi:
                Console.WriteLine("mavi");
                break;
            default:
                Console.WriteLine("renk bilinmiyor");
                break;
        }
        Console.WriteLine("UYGULAMA 1 SONU--------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
        Console.WriteLine("UYGULAMA 2-------------------------------------------------------------------");

        Random rnd=new Random();
        int caseSwitch = rnd.Next(1,10);
        switch (caseSwitch)
        {
            case 1:
                Console.WriteLine("Durum 1");
                break;
            case 2:
                Console.WriteLine("durum 2");
                break;
            case 3:
                Console.WriteLine("durum 3");
                break;
            default:
                Console.WriteLine($"case {caseSwitch} : durum dışı");
                break;
        }

        Console.ReadKey();
        Console.WriteLine("UYGULAMA 2 SONU ---------------------------------------------------------------");

    }
}