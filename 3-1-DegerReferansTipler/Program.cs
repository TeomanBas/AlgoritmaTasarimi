internal class Program
{
    private static void Main(string[] args)
    {
        //Dğer tiplere örnek
        int num1 = 10;
        int num2 = 20;
        num2 = num1;
        num1 = 33;
        Console.WriteLine(num2);
        Console.WriteLine("--------------------");
        string[] arr1 =new string[]{ "ankara", "izmir", "istanbul" };
        string[] arr2 = new string[] { "bursa", "antalya"};
        arr2 = arr1;
        foreach(string s in arr2)
        {
            Console.WriteLine(s);
        }
        //artık arr2 dizisini kaybettik garbage collection tarafından temizlenir ve arr2 nin adresi arr1 i gösterir.

    }
}