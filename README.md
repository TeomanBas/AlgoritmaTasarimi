# AltoritmaTasarimi
Burada Algoritma Tasarımı Notlarım ve Uygulamalarım Bulunuyor.

## Değer Tipli Değişkenler
|Tipi|Cts tipi| Kapladığı Alan|
|---|---|---|
|byte|System Byte|8 bit işaretsiz tamsayı|
|sbyte|System Byte|8 bit işaretli tamsayı|
|short|System Int16|8 bit işaretsiz tamsayı|
|ushort|System Int16|8 bit işaretli tamsayı|
|int|System Int32|8 bit işaretsiz tamsayı|
|uint|System UInt32|8 bit işaretli tamsayı|
|long|System UInt32|8 bit işaretsiz tamsayı|
|ulong|System UInt64|8 bit işaretli tamsayı|
|float|System.Single|32 bit tek kayan sayı|
|double|System.Double|64 bit çift kayan sayı|
|decimal|System.Decimal|128 bit ondalıklı sayı|
|bool|System.Boolean||
|char|System.Char|16 bit unicode|

## Referans tipli
|Değişken Tipi|Açıklama|
|---|---|
|string|Unicode karakterleirnden oluşan string|
|object|Genel veri tipi.Tip dönüşümlerinde oluşan hatalar derleme esnasında göz ardı edilerek çalışma zamanında hata üretilir.|
|dynamic|Genel veri tipi.Tip dönüşümlerinde oluşan hatalar üzerinde derleme esnasında herhangi bir kontrol yapılmadığı için hata üretilmez|

## Var
- Değişken tanımı yapılırken tip belirtilmeden var deyimi kullanılabilir
- var ifadesi ile tanımlanan değişkenler için ilk değer ataması yapılmalıdır.
- Değişkenin tipi kullanılan veri türüne bağlı olarak C# tarafından otomatik olarak belirlenecektir.
- c# 7 versiyonu ile gelen digit seperator özelliği ile rakamları basamaklarına ayırarak daha düzenli bir şekilde yazabiliriz. örnek <code>int a = 33_000_000</code>

## GetType
- Kullanılan ya da tanımlanan veri türünün tipi almak üzere GetType deyimi kullanılır.

## Object/dynamic farkı
- object 
```Csharp
object rakam =10;
rakam = rakam + 10;
```
şeklinde bir işleme izin vermez bu kodlar hatalıdır.

- dynamic
```Csharp
dynamic rakam =10;
rakam = rakam + 10;
```
şeklinde bir kullanıma izin verir

## Kontrol İfadeleri if-else yapısı
- Programlar farklı durumlarda farklı davranışlar sergileyecek,koşulları kontrol edip duruma göre herek edilmesini sağlayacak kontrol yapılarını kullanmak kaçınılmazdır.
- Visual C# dili,kontrol ifadelerini yakalamak için Boolean türünde bir tip içerir, bu tip sayesinden kontrol ifadeleri kullanılabilir.
### Eşitlik durumları
|işleç|Anlamı|Örnek|Yas 27 ise Sonuç|
|---|---|---|---|
|==|eşittir|yas==100|False|
|!=|eşit Değildir|yas!=0|True|
|<|Küçüktür|Yas<21|False|
|<=|Küçük ya da eşit|Yas<=27|True|
|>|büyüktür|Yas>16|True|
|>=|büyük ya da eşit|Yas>=30|False|

### Koşullu mantıksal işleçler
<code>(yas>=18)&&(yas<=30)</code> ifadesinden iki koşulunda sağlanması durumunda örneğin yaş 27 ise iki koşuluda sağlar ve True değeri döner

<code>(yas>=18)||(yas<=30)</code> ifadesinde koşullardan sadece birinin gerçekleşmesi yeterlidir ikiside gerçekleşmemiş ise False dönecektir. 

## Switch Case Kavrami
- Switch durumu kendisine parametre olarak gelen kodtrol değerine bağlı olarak durum listesinden ilgili kod bloğunun çalıştırılmsı esasına dayanmaktadır.switch deyimi birden switch seçimi ile birlikte varsayılan (default)  bir seçimide içerebilir.
- Durum listesinde aynı sabit değere sahip iki durum tanımlamasının yapılmasına izin verilmez
- C#,C++ dilinin aksine break deyimi kullanılmadığı zamansırasıyla durumlar çalıştırmak yerine hata üretecektir.

## For Döngüsü
- For döngüsü kullanılarak özel bir şartın yerine gelmesi sağlanıncaya kadar belirli bir kod bloğunun çalışması sağlanabilir.For döngüsü başlangıç değeri koşul ve yineleyici bileşenlerinden oluşmaktadır.
- Öncelikle başlangıç değerinin oluşturulması ya da okunması gereklidir.Başlangıç değişkenindeki değere bağlı olarak koşul sonucu pozitif ya da bir başka ifadeyle true yani doğru ise döngüye giriş yapılır.
- Döngü tamamlanmadan önce başlangıç değeri yineleme bölümünde verilen operasyona bağlı olarak güncellenir ve daha sonra tekrar koşul ifadesine bakılır.Koşul ifadesi doğru olduğu sürece döngü çalışmaya devam edecektir.
- Döngü oluşturulurken başlangıç,koşul ve yineleme bileşenleri tek değişken olmak zorunda değildir.Birden fazla değişken ilede döngü kurulabilir.
- Özel bir şart altında istenirse break komutu ile döngünün sonlandırılması sağlanabilir yada ilgili yenileme iptal edilip bir sonraki yenileme işlemine geçmek üzere continue deyimi kullanılabilir.
- Yenileme beleşeninde ön ek (++i) ya da son ek (i++) kullanılarak atama işlemi gerçekleştirilebilir.Yineleme bileşeni arttığı gibi azaltılabilir.Döngü içerisinde yeni bir nesne tanımlanabilir. aritmetiksel ve mantıksal işlemler yapılabilir.

## Diziler
- Aynı türden/tipden verileri belirli bir kalıp dahilinde saklamak üzere kullanılan yapılar dizi (array) olarak tanımlanır.
- Diziler tanımlanırken kaç elemean depolayacağı ve boyutu genellikle tanımlama esnasında bildirilir.
- Diziler üzerindeki her bir elemana erişmek üzere indis değerleri kullanılır.
- Tek boyut bir dizi tanımlandığında hafızada dizinin tanımlandıı veri türüne bağlı olarak eşit uzunluklara sahip gözler açılır.
- Her bir gözün, yani dizi elemanı için ayrılmış alanın,bir adresi ve indis değeri vardır.
### Tek Boyutlu Diziler
- **Tanımlama şekilleri**<br>
    Aşağıda 5 tane tam sayı tutacak bir dizi tanımı gerçekleştiriliyor 
    ```c#
    int[] array = new int[5];
    ```
    Bu dizinin elemanları array[0] ve array[4] aralığında yer alır.yani indis değeri 0 ile başlar

    Dizi tanımlama (decleration) aşamasında dizi uzunluğu belirtmeden dizi tanımlamak mümkündür.
    ```c#
    int[] array1= new int[] { 1, 2, 3, 4, 5, 6};
    ```
    Burada zaten virgül ile ayrılmış elemanların sayısı dizi uzunluğu temsil etmektedir.

    Dizi oluşturma aşamasında eğer değerler atanıyorsa tanımlama ifadesi kısaltılabilir.
    ```c#
    int[] array2 = {1, 2, 3, 4, 5, 6, 7};
    string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};
    ```
    Görüldüğü üzere new anahtar kelimesini kullanılmasına gerek kalmamıştır.

    - Dizi oluşturma aşaması dışında da tanımlanabilir bu durumda  new anahtar kelimesi kullanılmalıdır.
    ```c#
    int[] array3;
    array3 = new int[] { 1, 2, 3, 4, 5, 7, 8} // bu kod çalışır
    array3 = { 1, 2, 3, 4, 5, 7, 8} // bu kod hata verir ve çalışmaz. 
    ```
### Çok Boyutlu Diziler(Multidimensional Array)
- **Tanımlama Şekilleri**<br>
    Aşağıdaki deklarasyonda 4 satır ve 2 sütundan oluşan bir dizi tanımı gerçekleştirilmiştir.
    ```c#
    int[,] array = new int[4,2];
    ```
    Diziler birden fazla boyuta sahip olabilmektedir.

## Stringler
- String nesnesinin değeri System.Char nesnelerinin sıralı koleksiyonunun içerisidir ve bu değer sabittir(yani salt okunurdur).
- Bellekteki String nesnesinin en büyük boyutu 2 GB veya yaklaşık 1.000.000.000 karakterdir.
- String ifadeleri metinleri temsil etmek üzere kullanılan ardışık bir karakter koleksiyonudur.
- String nesnesi bir diziyi temsil eden System.Char nesnelerinden oluşan sıralı bir koleksiyondur.
- c# ters eğik çizgi (\) bir kaçış karakteri olduğundan bir dizedeki değişmez değer ters eğik çizgilerden çıkarılmalıdır ve dizenin tamamının @-quoted olması gerekir.
    ```c#
    string string1 = "This is a string created by assignment";
    Console.WriteLine(string1);
    string string2a = "The path is C:\\PublicDocuments\\Report1.dox";
    Console.WriteLine(string2a);
    string string2b = @"The path is C:\PublicDocuments\Report1.dox";
    Console.WriteLine(string2b);
    // The example displays the following output:
    //      This is a string created by assignment
    //      The path is C:\PublicDocuments\Report1.doc
    //      The path is C:\PublicDocuments\Report1.doc
    ```
### String Oluşturma
```c#
char[] chars = { 'w', 'o', 'r', 'd' };
sbyte[] bytes = { 0x41, 0x42, 0x43, 0x44, 0x45, 0x00 };

// Create a string from a character array.
string string1 = new string(chars);
Console.WriteLine(string1);

// Create a string that consists of a character repeated 20 times.
string string2 = new string('c', 20);
Console.WriteLine(string2);

string stringFromBytes = null;
string stringFromChars = null;
unsafe
{
   fixed (sbyte* pbytes = bytes)
   {
      // Create a string from a pointer to a signed byte array.
      stringFromBytes = new string(pbytes);
   }
   fixed (char* pchars = chars)
   {
      // Create a string from a pointer to a character array.
      stringFromChars = new string(pchars);
   }
}
Console.WriteLine(stringFromBytes);
Console.WriteLine(stringFromChars);
// The example displays the following output:
//       word
//       cccccccccccccccccccc
//       ABCDE
//       word
```
### String Birleştirme
```c#
string string1 = "Today is " + DateTime.Now.ToString("D") + ".";
Console.WriteLine(string1);

string string2 = "This is one sentence. " + "This is a second. ";
string2 += "This is a third sentence.";
Console.WriteLine(string2);
// The example displays output like the following:
//    Today is Tuesday, July 06, 2011.
//    This is one sentence. This is a second. This is a third sentence.
```
### String Ayıklama
- String ifadeleirnde,örnek bir alt dize, daha büyük bir ifadeden ayıklanabilir.
```c#
string sentence = "This sentence has five words.";
// Extract the second word.
int startPosition = sentence.IndexOf(" ") + 1;
string word2 = sentence.Substring(startPosition,
                                  sentence.IndexOf(" ", startPosition) - startPosition);
Console.WriteLine("Second word: " + word2);
// The example displays the following output:
//       Second word: sentence
```
### String Dönüşümü
- Farklı veri tipleri string gösterimine dönüştürülebilir.
```c#
DateTime dateAndTime = new DateTime(2011, 7, 6, 7, 32, 0);
double temperature = 68.3;
string result = String.Format("At {0:t} on {0:D}, the temperature was {1:F1} degrees Fahrenheit.",
                              dateAndTime, temperature);
Console.WriteLine(result);
// The example displays the following output:
//       At 7:32 AM on Wednesday, July 06, 2011, the temperature was 68.3 degrees Fahrenheit.
```
### UTF-16
- Bir dizdeki her karakter,Unicode kod noktası olarak da bilinen Unicode skaler değeri veya Unicode karakterinin Ordinal(Sayısal) değeri tarafından tanımlanır.
- Her kod noktası UTF-16 kodlaması kullanılarak kodlanır ve kodlamadaki her öğenin sayısal değeri Char nesnesi ile temsil edilir.
### Dizeler ve Dizinler
- Dizin **String**'de bir **Char** nesnesinin konumudur(Unicode karakteri değil)
- Dizin, dizin konumu sıfır olan dizedeki ilk konumdan başlayan sıfır tabanlı, negatif olmayan bir sayıdır.
- **IndexOf** ve **LastIndexOf** gibi çeşitli arama yöntemleri dize örneğindeki bir karakter veya alt dizenin dizinini döndürür.
- **Chars[Int32] :** özelliği tek tek **Char** nesnelerine dizedeki dizin konumlarına göre erişmenizi sağlar.
- **Chars[Int32] :** özelliği varsayılan Özellik (Visual Basic) veya Dizin Oluşturucu (içinde C#) olduğundan,aşağıdaki gibi bir kod kullanarak bir dizedeki bireysel **Char** nesnelerine erişilebilir.
- Bu kod, dizenin kaç sözcükten oluşan sözcükleri belirlemekte bir dizedeki boşluk veya noktalama karakterleri arar.
```c#
string s1 = "This string consists of a single short sentence.";
int nWords = 0;

s1 = s1.Trim();      
for (int ctr = 0; ctr < s1.Length; ctr++) {
   if (Char.IsPunctuation(s1[ctr]) | Char.IsWhiteSpace(s1[ctr]))
      nWords++;              
}
Console.WriteLine("The sentence\n   {0}\nhas {1} words.",
                  s1, nWords);                                                                     
// The example displays the following output:
//       The sentence
//          This string consists of a single short sentence.
//       has 8 words.
```
### Null diziler ve Boş diziler
- Tanımlanan ancak atanmamış birdize null'dır.
- Bu dize üzerinde yöntem çağırma girişimi bir **NullReferenceException** oluşturur.
- **Null** dize, değeri "" veya **String.Empty** olan bir dize olan boş bir dizeden farklıdır.
- Bazı durumlarda, bir null dize veya boş bir dizeyi bir yöntem çağrısında bağımsız değişken olarak geçirmek özel durum oluşturur.
Örneğin **Int32.Parse** metoduna null bir dize geçirmek bir **ArgumentNullException** oluşturur ve boş bir dizeyi geçirmek bir **FormatException** oluşturur.
- Diğer durumlarda,bir yöntem bağımsız değişkeni bir null dize veya boş bir dize olabilir.Örneğin bir sınıf için IFormattable uygulama belirtecisine eşit olacak şekilde kullanmak istersiniz.
- **isNullOrEmpty(String) :** bir dizenin **null** veya String.Empty eşit olup olmadığını gösterir.Bu yöntem aşağıdaki gibi kod kullanma gereksinimini ortadan kaldırır.
```c#
if(str == null || str.Equals(String.Empty))
```
- **isNullOrWhiteSpace(string) :** bir dizenin **null**,eşit String.Empty veya yalnızca boşluk karakterlerinden oluşan bir değer olup olmadığını gösterir.Bu yöntem aşağıdaki gibi kod kullanma gereksinimini ortadan kaldırır:
```c#
if(str == null || str.Equal(String.Empty) || str.Trim().Equals(String.Empty))
```
- **isNUllOrWhiteSpace(string) :**
```c#
if (str == null || str.Equals(String.Empty) || str.Trim().Equals(String.Empty))
```
## StreamReader,StreamWriter,FileStream
### StreamReader
- Verilerin belirli bir formatta bir dosyaya yazılması,onların kalıcı belleğe aktarılması anlamına gelir.
- Kalıcı belleğe aktarılan veriler ihtiyaç duyulması halinde okunabilir,güncellenebili yada tamamen silinebilir.
- Dosyadan okuma yapmak için StreamReader nesnesi kullanılabilir.
- Bu nesne tanımlandığında  okunacak dosyanın fiziksel konum bilgisini de parametre olarak almalıdır.
- Dosyalama işlemlerinin bir try-catch bloğu içinde yapılması etkili hata yönetimi için tavsiye edilmektedir.
### StreamWriter
- Bir dosyaya yazma yapmak için StreamWriter nesnesi kullanılabilir.
- Bu nesne tanımlandığında  okunacak dosyanın fiziksel konum bilgisini de parametre olarak almalıdır.
- Dosyalama işlemlerinin bir try-catch bloğu içinde yapılması etkili hata yönetimi için tavsiye edilmektedir.

### FileStream
- FileStream sınıfı Stream sınıfından kalıtım tekniğiyle türetilmiş bir sınıftır.
```c#
FileStream fs = new FileStream(dosyayol,
FileMode.Append,
FileAccess.Write,
FileShare.Note);
```
- FileStream tanımı yapılırken:
   - FileMode: (Create,CreateNew,Append,Open,OpenOrCreate,Truncate)
   - FileAccess: (Read,Write,ReadWrite)
   - FileShare: (None,Read,Write,ReadWrite) belitilebilir.
- FileStream tanımına bağlı olarak yazma ve okuma gibi yetkilerin olup olmadığı kontrol edilebilir.
```c#
//fs.canRead,canWrite, ... 
if(fs.canRead){
   ...
}
```
- Açılan bir FileStream nesnesi için kapatma işlemi uygulanmalıdır ki yazma işlemi gerçekleşebilsin.
```c#
// yazma islemini tamamlamak için gereklidir.
fs.Close();
```