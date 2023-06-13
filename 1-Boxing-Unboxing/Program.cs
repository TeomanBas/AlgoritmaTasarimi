internal class Program
{
    private static void Main(string[] args)
    {
        // boxing
        // int değer tipli
        int i = 22;
        // object tipi referans tipli bir yapıdır yani heap de i nin adresi tutulur ve o değişkeni i yi işaret eder
        // buradaki atamayı yapabilmemizin sebebi object veri türünün int veri türünü kapsamısıdır.object int veri türünü kapsar.
        // int veri türü object veri türüne dönüştürülebilir ancak object veri türü int veri türüne dönüştürülemez.bunu cast işlemi ile yapabiliriz. 
        //object referans tipli
        object o = i;

        //explicit boxing-açıktan kutulama
        //object o=(object)i;

        // unboxing
        i *= 2;
        Console.WriteLine("o' nun değeri : {0} --- i' nin değeri {1}",o,i);
        //i = (int)o;
        Console.WriteLine("cast işlemi sonrası...");
        Console.WriteLine("o' nun değeri : {0} --- i' nin değeri {1}", o, i);
        Console.WriteLine("o'nun üzerinde 5 ile çarpma işlemi yapılıyor");
        o = (int)o * 5;
        Console.WriteLine("o' nun değeri : {0} i' nin değeri {1}", o, i);



        Console.ReadKey();
    }
}