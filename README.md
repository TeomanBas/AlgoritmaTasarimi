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
