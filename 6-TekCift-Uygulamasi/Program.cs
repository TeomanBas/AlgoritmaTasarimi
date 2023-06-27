namespace _6_TekCift_Uygulamasi
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if (TekCift.Tek(n))
            {
                Console.WriteLine("girilen sayi tek");
            }
           
            if (TekCift.Cift(n))
            {
                Console.WriteLine("girilen sayi çift");
            }
        }
    }
}