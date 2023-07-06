internal class Program
{
    private static void Main(string[] args)
    {
        int limit = Convert.ToInt32(Console.ReadLine());

        int[] sayilar = new int[limit];
        for(int i = 0; i < limit; i++)
        {
            sayilar[i] = new Random().Next(1, 100);
            Console.Write("{0,5}",sayilar[i]);
        }
        Console.WriteLine("\n en büyük eleman {0}", maks(sayilar));
        Console.WriteLine("\n en küçük eleman {0}", min(sayilar));


    }

    public static int maks(int[] dizi)
    {
        int ek = dizi[0];
        for(int i = 1; i < dizi.Length; i++)
        {
            if(ek < dizi[i])
            {
                ek = dizi[i];
            }
        }
        return ek;
    }
    public static int min(int[] dizi)
    {
        int ek = dizi[0];
        for (int i = 1; i < dizi.Length; i++)
        {
            if (ek > dizi[i])
            {
                ek = dizi[i];
            }
        }
        return ek;
    }
}