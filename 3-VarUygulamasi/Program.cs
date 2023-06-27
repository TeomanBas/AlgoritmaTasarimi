internal class Program
{
    private static void Main(string[] args)
    {
        var v = 23;// Implicitly typed
        int x = 23;// Explicitly typed


        /*linq yapısı elemanların tipini yazdırmak
        string[] meyveler = { "elma", "armut", "muz", "üzüm", "şeftali" };
        var meyve = from m in meyveler
                    where m[0 ]== 'a'
                    select m;
        Console.WriteLine(meyve);
        */
        
        Console.ReadKey();
    }
}