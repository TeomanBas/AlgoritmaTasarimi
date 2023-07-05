internal class Program
{
    public static int SayilarToplamiFormul(int x)
    {
        int toplam = (x * (x + 1))/ 2;
        return toplam;
    }
    public static int SayilarToplamiSirayla(int x)
    {
        int t = 0;
        for (int i = 1; i <= x; i++)
        {
            t += i;
        }
        return t;
    }
    private static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" {0} sayısına kadar olan sayıların toplamı {1,5}", x , SayilarToplamiFormul(x));
        Console.WriteLine("--------------");
        Console.WriteLine(" {0} sayısına kadar olan sayıların toplamı {1,5}", x, SayilarToplamiSirayla(x));
    }
}