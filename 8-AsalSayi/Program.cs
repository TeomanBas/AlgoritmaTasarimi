internal class Program
{
    // FONKSİYON VEYA METOT İÇERİSİNDE RETURN ETTİKTEN SONRAKİ SATIRLAR ÇALIŞMIYOR EN SON RETURN DE ÇIKIŞ DEĞERİNİ
    // DÖNDÜRÜP PROGRAMI SONLANDIRIYOR.
    public static bool AsalKontrol(int n)
    {
        bool Kontrol = true;
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n>2)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    Kontrol = false;
                    break;
                }
            }
            
        }
        return Kontrol;
    }
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(AsalKontrol(n) ? "sayı asal" : "sayı asal değil");
    }
}