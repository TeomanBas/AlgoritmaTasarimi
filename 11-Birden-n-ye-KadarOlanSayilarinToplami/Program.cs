internal class Program
{
    // TEK SAYILAR
    public static int TekYontem1(int n)
    {
        int t = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 1)
            {
                t += i;
            }
        }
        return t;
    }
    public static int TekYontem2(int n)
    {
        int t = 0;
        for (int i = 1;i <= n; i += 2)
        {
            t += i;
        }
        return t;
    }
    public static int TekYontem3(int n)
    {
        n = n + 1;
        n = n / 2;
        return n * n;
    }
    // ÇİFT SAYILAR
    public static int CiftYontem1(int n)
    {
        int t = 0;
        for (int i = 2; i<= n; i += 2)
        {
            t += i;
        }
        return t;
    }
    public static int CiftYontem2( int n)
    {
        n = n / 2;
        return n * (n+1);
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("-------TEK SAYILAR--------");

        int n = Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine("yöntem 1 : {0}", TekYontem1(n));
        Console.WriteLine("yöntem 2 : {0}", TekYontem2(n));
        Console.WriteLine("yöntem 3 : {0}", TekYontem3(n));

        Console.WriteLine("-------ÇİFT SAYILAR--------");
        Console.WriteLine("yöntem 1 : {0}", CiftYontem1(n));
        Console.WriteLine("yöntem 2 : {0}", CiftYontem2(n));


    }
}