internal class Program
{
    private static void Main(string[] args)
    {
        string ifade = Console.ReadLine();
        StringAyikla(ifade);
    }
    public static void StringAyikla(string n)
    {
        string[] bolunmusifade = n.Split(',');
        int x = bolunmusifade.Length;
        int[] sayisalDizi = new int[x];
        for (int i = 0;i<x;i++)
        {
            sayisalDizi[i] = Convert.ToInt32(bolunmusifade[i]);
            Console.WriteLine("dizi[{0}] = {1}", i, sayisalDizi[i]);
        }
    }
}