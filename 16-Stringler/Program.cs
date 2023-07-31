internal class Program
{
    private static void Main(string[] args)
    {
        DesenOlustur();
        DesenOlustur(-30);
        DesenOlustur(15,'X');
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(new string('-',22));
        string ifade = " Denemeler ve Örnekler ";
        Console.WriteLine(ifade);
        Console.WriteLine("ifadenin uzunluğu #### {0} ",ifade.Length);
        Console.WriteLine("ifadenin başındaki ve sonundaki boşlukların kesilmesi #### {0} ", ifade.Trim());
        Console.WriteLine("Trim edilmiş ifadenin uzunluğu #### {0} ", ifade.Trim().Length);
        Console.WriteLine("ifadenin başındaki boşlukların kesilmiş ifade #### {0} ", ifade.TrimStart());
        Console.WriteLine("TrimStart ile başındaki boşlukların kesilmiş ifadenin uzunluğu #### {0} ", ifade.TrimStart().Length);
        Console.WriteLine("Trimend ile sonundaki boşlukların kesilmiş ifade #### {0} ", ifade.TrimEnd());
        Console.WriteLine("Trimend ile sonundaki boşlukların kesilmiş ifadenin uzunluğu #### {0} ", ifade.TrimEnd().Length);
        Console.WriteLine("ifadenin harflerinin küçültülmesi ToLover #### {0}", ifade.ToLower());
        Console.WriteLine("ifadenin harflerinin büyütülmesi ToUpper #### {0}", ifade.ToUpper());
        Console.WriteLine("ifade içerisinki e karakterlerinin a ya dönüştürülmesi replace edilmesi #### {0}", ifade.Replace('e','a'));

        Console.WriteLine("-----------------------");
        Kelime("kelime1", "kelime2");


    }

    public static void DesenOlustur()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("{0,10}{0}", new string('*', i), new string('*', i));
        }


    }
    public static void DesenOlustur(int n)
    {
        if (n <= 0)
        {
            for (int i = n; i <=0; i++)
            {
                Console.WriteLine("{0,70}{0}", new string('*', -i), new string('*', -i));
            }
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0,20}{0}", new string('*', i), new string('*', i));
            }
        }
    }
    public static void DesenOlustur(int n,char desen)
    {
        if (n <= 0)
        {
            for (int i = n; i <= 0; i++)
            {
                Console.WriteLine("{0,70}{0}", new string(desen, -i), new string(desen, -i));
            }
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0,20}{0}", new string(desen, i), new string(desen, i));
            }
        }
    }
    public static void Kelime(string kelime1,string kelime2)
    {
        // dönüş değişkeni oluşturulmak bazen gereksiz olabilir Bunun için String.Format() kullnılabilir.
        string kelimeler = String.Format("{0}{1}", kelime1, kelime2);
        Console.WriteLine(kelimeler);
    }
}