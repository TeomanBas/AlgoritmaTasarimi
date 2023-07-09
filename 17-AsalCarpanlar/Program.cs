internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Asal çarpanlar : ");
        Yazdir(AsalCarpanlar(432));
        Console.WriteLine();
        Console.Write("Asal çarpanlar toplamı :");
        Yazdir(AsalCarpanToplam(AsalCarpanlar(432)));
        Console.WriteLine();
        Console.Write("Asal çarpanlar çarpımı :");
        Yazdir(AsalCarpanCarpim(AsalCarpanlar(432)));
    }
    public static int[] AsalCarpanlar(int n)
    {
        string carpanlistesi = "";
        int i = 2;

        while (n > 1)
        {
            if (n%i== 0)
            {
                n = n / i;
                carpanlistesi += i.ToString()+",";
            }
            else
            {
                i++;
            }
        }
        carpanlistesi = carpanlistesi.Substring(0, carpanlistesi.Length - 1);
        string[] carpanlar = carpanlistesi.Split(',');
        string s = carpanlar[0];
        string y = s;

        for(i=0; i < carpanlar.Length; i++)
        {
            if (!(s == carpanlar[i]))
            {
                y = y + "," + carpanlar[i];
                s = carpanlar[i];
            }
        }
        carpanlar = y.Split(",");
        int[] AsalCarpanlar = new int[carpanlar.Length];
        for (i = 0; i<AsalCarpanlar.Length; i++)
        {
            AsalCarpanlar[i] = Convert.ToInt32(carpanlar[i]);
        }   
        return AsalCarpanlar;
    }
    public static void Yazdir(int[] dizi)
    {
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.Write(dizi[i]+" ");
        }
    }
    public static void Yazdir(int sayi)
    {
        Console.Write(sayi);
    }
    public static int AsalCarpanToplam(int[] dizi)
    {
        int t=0;
        for(int i = 0;i < dizi.Length; i++)
        {
            t += dizi[i];
        }
        return t;
    }
    public static int AsalCarpanCarpim(int[] dizi)
    {
        int c = 1;
        for (int i = 0; i < dizi.Length; i++)
        {
            c *= dizi[i];
        }
        return c;
    }

}