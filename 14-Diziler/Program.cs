internal class Program
{
    private static void Main(string[] args)
    {
        int[] dizi=DiziOlustur();
        Console.WriteLine("\n en büyük eleman {0}", maks(dizi));
        Console.WriteLine("\n en küçük eleman {0}", min(dizi));
        Console.WriteLine("\n aritmetik ortalama {0}", aritmetikOrt(dizi));
        Console.WriteLine("\n dizinin standart sapması : {0:F2}",StandartSapma(dizi));
        Console.WriteLine("\n dizi içerisindeki tek sayıların sayısı {0}",TekSay(dizi));
        Console.WriteLine("\n tek sayıların dizisi ");
        DiziYazdir(TekDiziOLustur(dizi, TekSay(dizi)));
        Console.WriteLine();
        Console.WriteLine("\n dizi içerisindeki çift sayıların sayısı {0}", CiftSay(dizi));
        Console.WriteLine("\n çift sayıların dizisi ");
        DiziYazdir(CiftDiziOLustur(dizi, CiftSay(dizi)));
        Console.WriteLine();






    }
    public static int[] DiziOlustur()
    {
        int limit = Convert.ToInt32(Console.ReadLine());

        int[] sayilar = new int[limit];
        for (int i = 0; i < limit; i++)
        {
            sayilar[i] = new Random().Next(1, 100);
            Console.Write("{0,5}", sayilar[i]);
        }
       
        return sayilar;
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
    public static int aritmetikOrt(int[] dizi)
    { 
        int top = 0;
        int ort=0;
        for (int i = 0;i < dizi.Length; i++)
        {
            top += dizi[i];
        }
        return ort=top/dizi.Length;
    }
    public static double StandartSapma(int[] n)
    {
        double t = 0, f = 0;
        double aritmetikort = aritmetikOrt(n);
        for (int i = 0; i < n.Length; i++)
        {
            f = n[i] - aritmetikort;
            t += Math.Pow(f, 2);
        }
        return Math.Sqrt(t / (n.Length - 1));
    }

    public static int CiftSay(int[] dizi)
    {
        int ciftsayisi = 0;
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] % 2 == 0)
            {
                ciftsayisi++;
            }
        }
        return ciftsayisi;
    }
    public static int TekSay(int[] dizi)
    {
        int teksayisi = 0;
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] % 2 != 0)
            {
                teksayisi++;
            }
        }
        return teksayisi;
    }
    public static int[] CiftDiziOLustur(int[] dizi,int elemansayisi)
    {
        int[] ciftdizi = new int[elemansayisi];
        int y = 0;
        for (int i = 0;i < dizi.Length; i++)
        {
            if (dizi[i] % 2 == 0)
            {
                ciftdizi[y] = dizi[i];
                y++;
            }
        }
        return ciftdizi;
    }
    public static int[] TekDiziOLustur(int[] dizi, int elemansayisi)
    {
        int[] tekdizi = new int[elemansayisi];
        int y = 0;
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] % 2 != 0)
            {
                tekdizi[y] = dizi[i];
                y++;
            }
        }
        return tekdizi;
    }
    public static void DiziYazdir(int[] dizi)
    {
        for(int i = 0;i < dizi.Length; i++)
        {
            Console.Write(dizi[i]+ ",  ");
        }

    }

}