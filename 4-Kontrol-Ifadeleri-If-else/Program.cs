internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("UYGULAMA 1-------------------------------------------------------------------");
        char tus = (char)Console.Read();
        if (char.IsUpper(tus))
        {
            Console.WriteLine("büyük harf");
        }
        else if (char.IsLower(tus))
        {
            Console.WriteLine("küçük harf");
        }
        else if(char.IsDigit(tus))
        {
            Console.WriteLine("sayı");
        }
        else
        {
            Console.WriteLine("karakter alfanümerik bir ifade değil");
        }
        Console.WriteLine("UYGULAMA 1 SONU--------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.ReadKey();
        Console.WriteLine("UYGULAMA 2-------------------------------------------------------------------");
        int m = 9;
        int n = 7;
        int p = 5;
        if(m>=n && m >= p)
        {
            Console.WriteLine("en büyük m");
        }
        if (m >= n && !(m <= p))
        {
            Console.WriteLine("en büyük m");
        }
        if (m > n || m > p)
        {
            Console.WriteLine("en büyük m");
        }

        Console.WriteLine("UYGULAMA 2 SONU--------------------------------------------------------------");
    }
}