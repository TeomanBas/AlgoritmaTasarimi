internal class Program
{
    //EĞER STATİC TANIMLANDI İSE BİR METOT NESNE OLUŞTURMADAN KULLANILABİLİR // 

    /// <summary>
    /// parametre olarak aldığı sayının mutlak değerini döner.
    /// </summary>
    /// <param name="n">girilen sayıdır</param>
    /// <returns>parametre olarak giirlen sayının mutlak değeridir.</returns>
    public static int MutlakDeger(int n)
    {
        if (n == 0)
            return 0;
        if (n > 0)
            return n;
        if (n < 0)
            return -1 * n;
        return n;
    }
    private static void Main(string[] args)
    {
        int n =Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(MutlakDeger(n));
    }
    
}