internal class Program
{
    private static void Main(string[] args)
    {
        for(int i=1; i<=10; i++)
        {
            for (int j=1; j<=10; j++)
            {
                Console.Write("{0,5}",i*j);
                
            }
            Console.WriteLine();
            if (i == 1)
            {
                Console.WriteLine(new string('-', 60));
            }

        }
    }
}