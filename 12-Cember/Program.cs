using _12_CemberinCevresi;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("yarı çap giriniz...");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("açı giriniz ...");
        double a = Convert.ToDouble(Console.ReadLine());
        // :F2 noktadan sonra iki basamak gösterilecek anlamına gelir  
        Console.WriteLine("--------------------------");
        Console.WriteLine("çemberin çevresi : 2*{0:F2} * {1:F2} = {2:F2}",Cember.pi,r,Cember.Cevresi(r));
        Console.WriteLine("çemberin alanı : {0:F2} * {1:F2}*{1:F2} = {2:F2}", Cember.pi, r, Cember.Alani(r));
        Console.WriteLine("çemberin içindeki {3} derecelik kısmın alanı : {0:F2} * {1:F2}*{1:F2} = {2:F2}", Cember.pi, r, Cember.Alani(r,a),a);


    }
}