using System.Collections.Generic;

List<int> sayiListesi=new List<int>();

sayiListesi.Add(23);
sayiListesi.Add(15);
sayiListesi.Add(230);
sayiListesi.Add(2);
sayiListesi.Add(35);

List<String> renkListesi=new List<string>();

renkListesi.Add("Mavi");
renkListesi.Add("Sarı");
renkListesi.Add("Yeşil");
renkListesi.Add("Siyah");
renkListesi.Add("Beyaz");
renkListesi.Add("Kırmızı");

//Count listenin kaç elemandan oluştuğunu döndürür.
Console.WriteLine(sayiListesi.Count);
Console.WriteLine(renkListesi.Count);

//foreach ile elemanlara erişim
sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
renkListesi.ForEach(renk=>Console.WriteLine(renk));


//Listeden eleman çıkarma => remove and removeAt
sayiListesi.Remove(2);
renkListesi.Remove("Yeşil");

sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
renkListesi.ForEach(renk=>Console.WriteLine(renk));

sayiListesi.RemoveAt(0);
renkListesi.RemoveAt(0);

sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
renkListesi.ForEach(renk=>Console.WriteLine(renk));

//Liste içi arama => Contains
if(sayiListesi.Contains(5)){
    Console.WriteLine("Liste içerisinde 5 rakamı vardır.");
}else{
    Console.WriteLine("Liste içerisinde 5 rakamı yoktur.");
}

//Dizi'yi listeye çevirme 
String[] dizi={"Kedi","Köpek","Aslan","Kartal","Serçe"};
List<String> hayvanListesi=new List<string>(dizi);

hayvanListesi.ForEach(hayvan=>Console.WriteLine(hayvan));

//liste temizleme işlemi
hayvanListesi.Clear();

//List içerisinde nesne tutmak
List<Kullanici> kullaniciListesi=new List<Kullanici>();
Kullanici kullanici1=new Kullanici();
kullanici1.Isim="Sevgin";
kullanici1.Soyisim="SERBEST";
kullanici1.Yas=36;
Kullanici kullanici2=new Kullanici();
kullanici2.Isim="Özcan";
kullanici2.Soyisim="ÇALIŞKAN";
kullanici2.Yas=45;
Kullanici kullanici3=new Kullanici();
kullanici3.Isim="Ahmet";
kullanici3.Soyisim="Mehmet";
kullanici3.Yas=85;

kullaniciListesi.Add(kullanici1);
kullaniciListesi.Add(kullanici2);
kullaniciListesi.Add(kullanici3);

kullaniciListesi.ForEach(kisi=>Console.WriteLine(kisi.Isim+" "+kisi.Soyisim+" Yaş : "+kisi.Yas));

List<Kullanici> yeniList=new List<Kullanici>();
yeniList.Add(new Kullanici(){
    Isim="Ali",
    Soyisim="veli",
    Yas=35
});
yeniList.Add(new Kullanici(){
    Isim="Mehmet",
    Soyisim="Ahmet",
    Yas=3
});

foreach (var item in yeniList)
{
    Console.WriteLine(item.Isim+" "+item.Soyisim+" Yaş : "+item.Yas);
}

public class Kullanici{
    private String isim;
    private String soyisim;
    private int yas;

    public string Isim{get => isim;set=>isim=value;}
    public string Soyisim{get => soyisim;set=>soyisim=value;}
    public int Yas{get => yas;set=>yas=value;}

}