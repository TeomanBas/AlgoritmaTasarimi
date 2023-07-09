internal class Program
{
    private static void Main(string[] args)
    {
        double x=Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("OBEB({0},{1})={2}",x,y,OBEB((int)x,(int)y));
    }
    public static int OBEB(int x, int y)
    {
        int sonuc = 1;
        int bolen = 2;
       while (x!=1 && y!=1)
        {
            for (int i = 2; i < (x > y ? x : y); i++)
            {
                if (x % bolen == 0 || y % bolen == 0)
                {
                    if (x % bolen == 0 && y % bolen == 0)
                    {
                        sonuc *= bolen;
                    }
                    if (y % bolen == 0)
                    {
                        y /= bolen;
                    }
                    if (x % bolen == 0)
                    {
                        x /= bolen;
                    }
                }
                else
                {
                    bolen++;
                }
            }
        }
        return sonuc;
    }
}