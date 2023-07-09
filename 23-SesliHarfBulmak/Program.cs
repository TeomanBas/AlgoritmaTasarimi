internal class Program
{
    private static void Main(string[] args)
    {
        string n=Convert.ToString(Console.ReadLine());
        SesliHarfBul(n);
    }
    public static void SesliHarfBul(string metin)
    {
        char[] kucuksesli = new char[8] { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
        char[] buyuksesli = new char[8] { 'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };
        int kucukseslisayisi = 0;
        int buyukseslisayisi = 0;

        for (int i = 0; i < metin.Length; i++)
        {
            for (int j = 0; j < kucuksesli.Length; j++)
            {
                if (metin[i] == kucuksesli[j])
                {
                    kucukseslisayisi++;
                }
            }
            for (int j = 0; j < buyuksesli.Length; j++)
            {
                if (metin[i] == buyuksesli[j])
                {
                    buyukseslisayisi++;
                }
            }
        }
        Console.WriteLine("büyük ve sesli harflerden {0} tane var",buyukseslisayisi);
        Console.WriteLine("kucuk ve sesli harflerden {0} tane var", kucukseslisayisi);


    }
}