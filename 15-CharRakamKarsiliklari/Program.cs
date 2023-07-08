internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 32; i <= 300; i++)
        {
            Console.Write("{0,5}",
                (char)i);
            if(i % 5 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}