internal class Program
{
    private static void Main(string[] args)
    {/*
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

        
        Console.WriteLine("bir matirisin traspozunu alır");
        Console.WriteLine(new string('-', 23));
        int[,] k = Olustur(3, 2);
        Yazdir(k);
        Console.WriteLine();
        int[,] tk = Transpoz(k);
        Yazdir(tk);
        Console.WriteLine(new string('-', 23));

        Console.WriteLine("bir matrisin şekilde değiştirmesi");
        int[,] sekil1 = Olustur(6, 4);
        Yazdir(sekil1);
        int[,] sekil2 =YenidenSekillendir(sekil1, 4, 6);
        Yazdir(sekil2);
        Console.WriteLine(new string('-', 23));
        */
        Console.WriteLine("iki matrisin karşılaştırması");
        int[,] matris1 = Olustur(6, 4);
        Yazdir(matris1);
        int[,] matris2 = Olustur(6, 4);
        Console.WriteLine();
        Yazdir(matris2);
        Console.WriteLine(new string('-', 23));
        if(EsitMi(matris2, matris2))
        {
            YazdirBasarili("başarılı");
        }
        else
        {
            YazdirHata("hata");
        }

        





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
    public static void YazdirHata(string mesaj)
    {

        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\a\n{0}\n\a",mesaj);
        Console.ResetColor();
    }
    public static void YazdirBasarili(string mesaj)
    {

        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\a\n{0}\n\a", mesaj);
        Console.ResetColor();
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
    public static int[,] Transpoz(int[,] x)
    {
        int[,] T = new int[x.GetLength(1),x.GetLength(0)];
        for (int i = 0;i < T.GetLength(0); i++)
        {
            for(int j = 0; j < T.GetLength(1); j++)
            {
                T[i,j] = x[j,i];
            }
        }
        return T;
    }
    public static int[,] YenidenSekillendir(int[,] x, int yenisatir,int yenisutun)
    {
        int[,] Y = new int[yenisatir, yenisutun];
        int[] D = new int[x.Length];
        int sayac = 0;
        if(x.Length== yenisatir*yenisutun)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    D[sayac] = x[i, j];
                    sayac++;
                }
            }
            sayac = 0;
            Yazdir(D);
            Console.WriteLine();
            for (int i = 0; i < Y.GetLength(0); i++)
            {
                for (int j = 0; j < Y.GetLength(1); j++)
                {
                    Y[i, j] = D[sayac];
                    sayac++;
                }
            }
        }
        else
        {
            Console.WriteLine("hata");
        }
        return Y;
    }
    public static bool EsitMi(int[,] x, int[,] y)
    {
        bool s = true;
        if(x.GetLength(0) == y.GetLength(0) && x.GetLength(1)==y.GetLength(1))
        {
            for(int i = 0;i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    if (x[i, j] != y[i, j])
                    {
                        s= false;
                        break;
                    }
                }
            }
        }

        return s;
    }
    
}