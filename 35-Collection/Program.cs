using System.Collections;
using Microsoft.VisualBasic;


internal class Program
{
    private static void Main(string[] args)
    {

        string s = "merhaba";
        IEnumerator rator = s.GetEnumerator();
        while (rator.MoveNext())
        {
            char c = (char)rator.Current;
            Console.Write(c+".");
        }
        Console.WriteLine("");
        Console.WriteLine(new string('-',50));

        Array dizi = Array.CreateInstance(typeof(Int32), 3);
        dizi.SetValue(23, 0);
        dizi.SetValue(42, 1);
        dizi.SetValue(22, 2);
        for (int i = 0; i < dizi.Length; i++)
        {
            Console.WriteLine(dizi.GetValue(i));
        }
        Console.WriteLine(new string('-', 50));

        int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, };
        List<int> list = new List<int>();
        string[] names = { "ali", "merve", "ayşe", "deniz" };
        for(int x = 5; x < arr.Length; x++)
        {
            list.Add(x);
        }
        ProcessItems<int>(list);
        ProcessItems<int>(arr);
        ProcessItems<string>(names);

    }

    private static void ProcessItems<T>(IList list)
    {
        Console.WriteLine("is readonly returns {0} for this collection.",
        list.IsReadOnly);
        foreach (T item in list)
        {
            Console.Write(item.ToString() + " ");
        }
        Console.WriteLine();
    }



    public class MyCollection : IEnumerable
    {
        int[] data = { 1, 2, 3, 4, 5, 6, };
        // GetEnumerator() fonksiyonu her çalıştığında data dizisinden sırayla bir elemanı dönecek
        public IEnumerator GetEnumerator()
        {
            foreach(int i in data)
            {
                // yield sözcüğü her çalıştığında data dizisinden sırayla bir elemanı dönecek
                yield return i;
            }
        }
    }
    internal class MyGenericCollection : IEnumerable<int>
    {
        int[] data = { 1, 2, 3, 4, 5, 6, };
        public IEnumerator<int> GetEnumerator()
        {
            foreach (int i in data)
            {
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}