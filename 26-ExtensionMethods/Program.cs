internal class Program
{
    private static void Main(string[] args)
    {
        string metin = "merhaba dünya";

        Console.WriteLine($"{metin.KelimeSayisi()}");
    }
}
public static class StringExtension
{
    public static int KelimeSayisi(this string s) => s.Split().Length;
}