internal class Program
{
    private static void Main(string[] args)
    {
        IkilikSayiDonusum("10101");
    }
    public static void IkilikSayiDonusum(string sayi)
    {
        int n = sayi.Length;
        int[] basamaklar= new int[n];
        int sayidegeri = 0;
        bool kontrol = true;
        for(int i = 0; i < n; i++)
        {
            if (!(sayi[i] == '0' || sayi[i] == '1'))
            {
                Console.WriteLine("\a Hatalı sayı");
                kontrol = false;
                break;
            }
            basamaklar[i]= sayi[i] - '0';
        }
        if (kontrol)
        {
            for (int i = 0; i < n; i++)
            {
                sayidegeri += (int)Math.Pow(2, n - 1 - i) * basamaklar[i];
            }
            Console.WriteLine("({0}) ikilik sayi = {1}",sayi,sayidegeri);
        }
    }
}