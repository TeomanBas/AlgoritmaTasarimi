internal class Program
{
    private static void Main(string[] args)
    {/*
        // Exception
        // System.FormatException
        // System.DivideByZeroException
        // System.NullReferenceException

        try
        {
            Console.WriteLine("1.sayı");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            var sonuc = sayi1 / sayi2;
            Console.WriteLine(sonuc);
        }// Exception Handling
        catch (FormatException)
        {
            Console.WriteLine("hatalı sayı formatı");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("sayı 0 olmamalıdır.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message + "bir hata oluştu");
        }
    */
        Console.Write("parola :");
        string parola = Console.ReadLine();
        try
        {
            ParolaKontrol(parola);
            Console.WriteLine("başarılı");
        }catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
    public static void ParolaKontrol(string password)
    {
        if(password.Length <0 || password.Length > 10)
        {
            throw new Exception ( "parola 6-10 karakter aralığında olmalıdır." );

        }
        if (!password.Any(char.IsDigit) )
        {
            throw new Exception("parola en az bir rakam içermelidir.");
        }
        if (!password.Any(char.IsLetter))
        {
            throw new Exception("parola en az bir rakam içermlidir.");
        }
    }
}