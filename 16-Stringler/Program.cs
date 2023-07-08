internal class Program
{
    private static void Main(string[] args)
    {
        DesenOlustur();
    }

    public static void DesenOlustur()
    {
       
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("{0,10}{0}",new string('*',i), new string('*', i));
        }
    }
}