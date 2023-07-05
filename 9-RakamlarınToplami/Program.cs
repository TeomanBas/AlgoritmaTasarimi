internal class Program
{
    public static int RakamlariToplami(int n)
    {
        int toplam = 0; int rakam = 0;
        while (n > 0)
        {
            rakam = n % 10;
            toplam += rakam;
            n = n / 10;
        }
        return toplam;
    }
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(RakamlariToplami(n));
    }
}