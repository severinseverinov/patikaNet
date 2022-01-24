using System.Collections;

ArrayList liste=new ArrayList();

liste.Add(2);
liste.Add("Ahmet");
liste.Add(true);
liste.Add('C');

Console.WriteLine(liste[1]);

foreach (var item in liste)
{
    Console.WriteLine(item);
}

//Addrange => birden fazla eleman ekleme
String[] renkler={"Kırmızı","Sarı","Mavi"};
List<int> listSayi=new List<int>(){3,5,8,9,12,15};

liste.AddRange(renkler);
liste.AddRange(listSayi);

foreach (var item in liste)
{
    Console.WriteLine(item);
}


//Sort
//liste.Sort(); runtime'da patlar çünkü içerisinde farklı türlerde veriler mevcut (aynı türde veriler varsa herhangi bir problem çıkmaz.)

//binarysearch => liste içerisinde sıralanmış ise istediğimiz verinin index'ini getirir.
//Console.WriteLine(liste.BinarySearch(9));

//Reverse => liste elemanlarının sırasını tersine çevirir.
liste.Reverse();
foreach (var item in liste)
{
    Console.WriteLine(item);
}
//clear => listenin içindeki tüm verileri temizler.
liste.Clear();