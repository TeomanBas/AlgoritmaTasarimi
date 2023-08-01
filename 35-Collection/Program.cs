using System.Collections;
using Microsoft.VisualBasic;


internal class Program
{
    private static void Main(string[] args)
    {

        //string s = "merhaba";
        //IEnumerator rator = s.GetEnumerator();
        //while (rator.MoveNext())
        //{
        //    char c = (char)rator.Current;
        //    Console.Write(c+".");
        //}
        //Console.WriteLine("");
        //Console.WriteLine(new string('-',50));

        //Array dizi = Array.CreateInstance(typeof(Int32), 3);
        //dizi.SetValue(23, 0);
        //dizi.SetValue(42, 1);
        //dizi.SetValue(22, 2);
        //for (int i = 0; i < dizi.Length; i++)
        //{
        //    Console.WriteLine(dizi.GetValue(i));
        //}
        //Console.WriteLine(new string('-', 50));

        //int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, };
        //List<int> list = new List<int>();
        //string[] names = { "ali", "merve", "ayşe", "deniz" };
        //for(int x = 5; x < arr.Length; x++)
        //{
        //    list.Add(x);
        //}
        //ProcessItems<int>(list);
        //ProcessItems<int>(arr);
        //ProcessItems<string>(names);
        //--------------------------------------------------------------------------------------

        // Collection non-generic ve generic olarak iki tipde bulunurlar
        // non-generic collections ,tip bağımlıdırlar
        // ArrayList ; int , string     

        ArrayList liste = new ArrayList();
        liste.Add(10);
        liste.Add("deneme mesajı");
        liste.Add("30");
        liste.Add(null);
        liste.Add(true);

        var liste2 = new ArrayList()
        {
            2,3,4,"deneme mesajı"
        };

        int[] sayilar = { 1, 2, 3 };

        liste.AddRange(sayilar);
        //obje olan elemean int tipine dönüştürüldü.
        var eleman = (int)liste[0];
        Console.WriteLine(eleman);

        // insert
        liste.Insert(1, "merhaba");
        liste.InsertRange(2, liste2);

        //remove
        // listeden ilk 1 değerine sahip olan elemannı siler
        liste.Remove(1);
        // listeden 2 indisli elemanı siler
        liste.RemoveAt(2);
        // başlangıç değerinden itibaren belirli sayıda elemanı listeden atar.
        liste.RemoveRange(2,3);



        // generic collection, tip bağımlı değildir aynı generic collection içinden birden fazla tip barındırılabilir.
        // int , string
        // Generic List
        List<int> sayilar1 = new List<int>();
        sayilar1.Add(10);
        sayilar1.Add(20);

        List<string> isimler = new List<string>() { "ali", "ayşe", "fatma" };

        List<Product> urunler = new List<Product>();
        urunler.Add(new Product() { id = 1234, name = "1234", description = "mesaj" });
        urunler.Insert(urunler.Count, new Product() { id = 124, name = "134", description = "mesaj2" });

        // Dictionary
        Dictionary<int, string> sayilar2 = new Dictionary<int, string>()
        { // object initializer
            {1,"bir"},
            {2,"iki"},
            {3,"üç"},

        };
        sayilar2.Add(35,"otuzbeş");
        sayilar2.Add(34, "otuzdört");

        Console.WriteLine(sayilar2[3]);

        // ContainsKey 3 indisli(Key) bir eleman varmı diye bakar varsa true yoksa false döner
        if (sayilar2.ContainsKey(3))
        {
            //Console.WriteLine(sayilar2[3]);
        }

        foreach (var item in sayilar2)
        {
            Console.WriteLine(item.Key + " -> "+ item.Value);
        }
    }
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
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