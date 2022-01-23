String degisken="Dersimiz CSharp, Hoşgeldiniz!";

//length
Console.WriteLine(degisken.Length);

//toUpper and toLower

Console.WriteLine(degisken.ToLower());
Console.WriteLine(degisken.ToUpper());

//concat => Birleştirme işlemi yapar
Console.WriteLine(String.Concat(degisken," Merhaba!"));

//Compare, CompareTo => karşılaştırma işlemi için kullanılır.(iki değişkenin karakter sayıları karşılaştırılır. eşitese=0 2>1=1 2<1=-1 değerlerinden birini döndürür.)
String degisken2="CSharp";
Console.WriteLine(degisken.CompareTo(degisken2));

Console.WriteLine(String.Compare(degisken,degisken2,true));//küçük büyük harf duyarlı iki değişken karşılaştırılır ve eşit ise 1 değilse 0 değerini döndürür.

//Contains => verilen değer değişken içerisinde varmı? varsa true
Console.WriteLine(degisken.Contains(degisken2));

//endsWith verilen değerle bitiyormu? startswith verilen değer ile başlıyormu?

Console.WriteLine(degisken.EndsWith("Merhaba!"));
Console.WriteLine(degisken.StartsWith("Dersimiz"));

//Indexof verilen değerin ilk yakaladığı index'ini verir. yoksa -1 döndürür.
Console.WriteLine(degisken.IndexOf("Merhaba"));

//Insert girilen index' istediğimiz değeri yerleştirir.
Console.WriteLine(degisken.Insert(0,"Merhabaaaa "));

//lastIndexOf verilen değeri arar ve en son bulduğu indexi verir.
Console.WriteLine(degisken.LastIndexOf("CSharp"));

//Padleft and Padright
Console.WriteLine(degisken+degisken2.PadLeft(30));//degisken2'yi verilen değere kadar sol tarafına boşluk koyar. Padright ise verilen değere atamamlanana kadar sağına boşluk koyar. yada verdiğimiz bir karakterle doldurur.
Console.WriteLine(degisken+degisken2.PadRight(40,'*'));

//remove => verilen indexten sonrasını siler.
Console.WriteLine(degisken.Remove(10));
Console.WriteLine(degisken.Remove(3,8));//3'ten başlayarak 8 karakter sil
Console.WriteLine(degisken.Remove(0,1));//ilk karakteri sil

//replace => verdiğimiz değeri değişken içerisinde bulur ve istediğimiz değerle değiştirebiliriz.
Console.WriteLine(degisken.Replace("CSharp","Java"));

//Split => verilen değere göre stringleri böler ve bir diziye atar.
Console.WriteLine(degisken.Split(" ")[1]);//degiskeni boşlukları baz alacak şekilde diziye at ve dizinin [1]. elemanını getir.

//substring(3,8) => verilen indexten istenen kadar değeri alır bize alt değişken olarak verir.
Console.WriteLine(degisken.Substring(3,8));



