internal class Program
{
    private static void Main(string[] args)
    {
        double x=Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("OKEK({0},{1})={2}",x,y,OKEK((int)x,(int)y));
    }
    public static int OKEK(int x, int y)
    {
        int s = 1;
        while (x!=1 && y!=1)
        {
            int bolme = 2;
            for (int i = 1; i < (x>y?x:y); i++)
            {
                if (x % bolme == 0 || y % bolme == 0)
                {
                    s *=bolme;
                    if(x%bolme == 0)
                    {
                        x = x / bolme;
                    }
                    if (y % bolme == 0)
                    {
                        y = y / bolme;
                    }
                }
                else
                {
                    bolme++;
                }
            }
        }
        return s;
    }
}