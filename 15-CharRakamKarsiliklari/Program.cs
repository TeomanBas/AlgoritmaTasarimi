internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ASCII KARAKTERLER");
        for (int i = 32; i <= 300; i++)
        {
            Console.Write("{0,5}",
                (char)i);
            if(i % 5 == 0)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
        Console.WriteLine("EXTENDED ASCII KARAKTERLER");
        for (int i = 128; i <= 254; i++)
        {
            Console.Write("{0,5}",
                (char)i);
            if (i % 5 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}