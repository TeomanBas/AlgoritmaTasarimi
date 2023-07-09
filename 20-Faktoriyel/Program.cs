internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Faktoriyel(6));
        AralikliFaktoriyel(10);
    }
    public static int Faktoriyel(int n)
    {
        if (n == 1) 
            return 1;
        int f = 1;
        for (int i = 2; i <= n; i++)
        {
            f *= i;
        }
        return f;
    }
    public static void AralikliFaktoriyel(int n)
    {
        int t= 0;
        for (int i = 1; i <= n; i++)
        {
            t += Faktoriyel(i);
            int s = Faktoriyel(i);
            Console.WriteLine("{0}! = {1}",i,s);
        }
        double ortalama = t / n;
        Console.WriteLine(" ortalama : {0}",ortalama);
    }
}