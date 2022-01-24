using System.Collections.Generic;

Dictionary<int,string> kullanici=new Dictionary<int, string>();

kullanici.Add(1,"Ahmet MEHMET");
kullanici.Add(10,"Ayşe YILMAZ");
kullanici.Add(11,"Mehmet AHMET");
kullanici.Add(12,"Ali VELİ");
kullanici.Add(0,"Sevgin SERBEST");
kullanici.Add(2,"Ali VELİ MEHMET");

//Dizinin elemanlarına erişme
Console.WriteLine(kullanici[0]);
foreach (var item in kullanici)
{
    Console.WriteLine(item.Key+" : "+item.Value);
}

//Count
Console.WriteLine(kullanici.Count);

//ContainsKey and containsValue
Console.WriteLine(kullanici.ContainsKey(3));
Console.WriteLine(kullanici.ContainsValue("Sevgin SERBEST"));

//remove eleman çıkartma
Console.WriteLine("Çıkarma işlemi : "+kullanici.Remove(12));