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