internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("matis örnek yapısı");
        Console.WriteLine(new string('-', 23));
        int[,] x= Olustur();
        Yazdir(x);
        Console.WriteLine(new string('-',23));

        Console.WriteLine("herbir boyutttaki her elemanı sıfır olan bir matris");
        Console.WriteLine(new string('-', 23));
        Yazdir(SifirMatris(3, 3));
        Console.WriteLine(new string('-', 23));

        Console.WriteLine("herbir boyuttaki her elemanı bir olan matris örneği");
        Console.WriteLine(new string('-', 23));
        Yazdir(BirMatris(3, 3));
        Console.WriteLine(new string('-', 23));

        Console.WriteLine("diagonal yani kare matris örneği herbir boyuttaki elemean sayısı eşittir");
        Console.WriteLine(new string('-', 23));
        Yazdir(DiagonalMatrisOlustur(4,0,0));
        Console.WriteLine(new string('-', 23));

        Console.WriteLine("skaler matris örneği diagonal olan bir matrisin çapraz elemanlarınn birbirnin aynısı olması durumunda oluşur");
        Console.WriteLine(new string('-', 23));
        Yazdir(SkalerMatrisOlustur(4, 1));
        Console.WriteLine(new string('-', 23));

        Console.WriteLine("diagonal matris kontrolü");
        Console.WriteLine(new string('-', 23));
        Console.WriteLine(DiagonalMi(Olustur(3,4)) ? "diagonal matris" :"diagonal matris değil");
        Console.WriteLine(DiagonalMi(DiagonalMatrisOlustur(4, 4)) ? "diagonal matris" : "diagonal matris değil");
        Console.WriteLine(new string('-', 23));

        Console.WriteLine("Birim matris tüm boyutları aynı (kare) ve aynı zamanda skaler bir matristir.asal elemanları (diagonal elemanları) 1 olan" +
            "ve diagonal elemanların dışındaki elemanları 0 olan matrislere birim matris adı verilir.");
        Console.WriteLine(new string('-',23));
        Yazdir(BirimMatris(5));
        Console.WriteLine(new string('-', 23));

        Console.WriteLine("birim matris kontrolü");
        Console.WriteLine(new string('-', 23));
        Console.WriteLine(BirimMatrisMi(Olustur()) ? "birim matris" : "birim matris değil");
        Console.WriteLine(BirimMatrisMi(BirimMatris()) ? "birim matris" : "birim matris değil");
        Console.WriteLine(new string('-', 23));

        Console.WriteLine("diagonal elemanları listeleme");
        Console.WriteLine(new string('-', 23));
        int[,] D = DiagonalMatrisOlustur();
        Console.WriteLine("matris");
        Yazdir(D);
        int[] xD =DiagonalElemanlarinListesi(D);
        Console.Write("diagonal elemanlar : ");
        Yazdir(xD);
        Console.WriteLine(new string('-', 23));

        Console.WriteLine("bir matrisin izi (Trace) , bir diagonal matrisin asal köşegenlerinin toplamıdır.");
        Console.WriteLine(new string('-', 23));
        int[,] trx = DiagonalMatrisOlustur();
        int[,] trd = Olustur(3,4);
        Console.WriteLine("Köşeden (diagonal matris)");
        Yazdir(trx);
        Console.WriteLine("matrisin izi : {0,5}", MatrisTrace(trx));
        Console.WriteLine("Köşeden olmayan matris");
        Yazdir(trd);
        Console.WriteLine("matrisin izi : {0,5}", MatrisTrace(trd) == 0 ? "yok çünkü matris köşeden değil" : "hata");
        Console.WriteLine(new string('-', 23));










    }

    public static int[,] Olustur(int satir = 3, int sutun = 3, int min = 1, int max = 9)
    {
        int[,] x = new int[satir, sutun];
        for (int i = 0; i < satir; i++)
        {
            for (int j = 0; j < sutun; j++)
            {
                x[i,j]= new Random().Next(min, max);
            }
        }
        return x;
    }
    public static void Yazdir(int[,] x)
    {
        for (int i = 0; i< x.GetLength(0); i++)
        {
            for(int j = 0;j< x.GetLength(1); j++)
            {
                Console.Write("{0,3}",x[i,j]);
                
            }
            Console.WriteLine();
        }
    }
    public static void Yazdir(int[] x)
    {
        for (int i = 0; i < x.Length; i++)
        {
            Console.Write(x[i]+", ");
        }
    }
    public static int[,] SifirMatris(int satir,int sutun)
    {
        return Olustur(satir, sutun, 0, 0);
    }
    public static int[,] BirMatris(int satir, int sutun)
    {
        return Olustur(satir, sutun, 1, 1);
    }
    public static int[,] DiagonalMatrisOlustur(int boyut=3,int min=1, int max = 9)
    {
        int[,] x = SifirMatris(boyut, boyut);
        for (int i = 0;i< x.GetLength(0); i++)
        {
            x[i,i]=new Random().Next(min,max);
        }
        return x;
    }
    public static int[,] SkalerMatrisOlustur(int boyut=3, int skaler=3)
    {
        return DiagonalMatrisOlustur(boyut, skaler, skaler);
    }
    public static bool DiagonalMi(int[,] x)
    {
        return x.GetLength(0) == x.GetLength(1) ? true : false;
    }
    public static int[,] BirimMatris(int boyut=3)
    {
        return SkalerMatrisOlustur(boyut,1);
    }
    public static bool BirimMatrisMi(int[,] x)
    {
        bool s = true;
        for (int i = 0; (i < x.GetLength(0) && s == true); i++)
        {
            for (int j = 0; j < x.GetLength(1); j++)
            {
                //diagonal elemanların dışındaki elemanlar
                if (x[i, j] != 0 && i != j)
                {
                    s = false; break;
                }
                // diyagonal elemanlar 1 mi?
                else
                {
                    if (x[i,i] != 1 && i == j)
                    {
                        s=false; break;
                    }
                }
            }
        }
        return s;
    }
    public static int[] DiagonalElemanlarinListesi(int[,] x)
    {
        if (DiagonalMi(x))
        {
            int[] dizi = new int[x.GetLength(0)];
            for (int i = 0; i < x.GetLength(0); i++)
            {
                dizi[i]= x[i,i];
            }
            return dizi;
        }else
            return  new int[0];
    }
    public static int MatrisTrace(int[,] x)
    {
        int t = 0;
        if (DiagonalMi(x))
        {
            int[] D = DiagonalElemanlarinListesi(x);
            for (int i = 0; i < x.GetLength(0); i++)
            {
                t += x[i, i];
            }
            return t;
        }
        else
            return t;


    }
}