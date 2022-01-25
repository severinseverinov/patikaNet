Console.WriteLine("Çalışılan Sayısı : {0}",Calisan.CalisanSayisi);
Calisan emp1=new Calisan("Sevgin","SERBEST","Arge");
Calisan emp2=new Calisan("Elif","SERBEST","Arge");
Calisan emp3=new Calisan("Ali","VELİ","Bakım");
Console.WriteLine("Çalışan sayısı : {0}",Calisan.CalisanSayisi);


//Islemler.Topla(25,85); static olarak tanımlana sınıflara erişim direk olur yeni bir nesne tanımlamaya gerek yok.

//Enum lar içerisinde değerleri sabit olarak tutmak için kullanılır. ve bellekte sıralı bir şekilde tutulur.
//Ayrıca enumlar kodun okunurluluğunu arttırır.
Console.WriteLine(Gunler.Pazar);
Console.WriteLine((int)Gunler.Cumartesi);

//Programda bazı veriler sabitler halinde tutulacağı zaman sıklıkla başvurulan yapıdır.
int sicaklik=32;
if(sicaklik<=(int)HavaDurumu.Normal){
    Console.WriteLine("Dışarıya çıkmak için biraz daha bekleyelim.");
}else if(sicaklik>=(int)HavaDurumu.Sıcak){
    Console.WriteLine("Dışarıya çıkmak içim çok sıcak bir gün.");
}else if(sicaklik>=(int)HavaDurumu.Normal && sicaklik<=(int)HavaDurumu.CokSıcak){
    Console.WriteLine("Hadi dışarıya çıkalım.");
}



class Calisan{
    private static int calisanSayisi;
    private String isim;
    private String soyisim;
    private String department;

    static Calisan(){//static olan tanımlayıcılar bir defa çalışır.
        calisanSayisi=0;
    }
    public Calisan(string isim, string soyisim, string department)
    {
        this.isim = isim;
        this.soyisim = soyisim;
        this.department = department;
        calisanSayisi++;
    }

    public static int CalisanSayisi { get => calisanSayisi;}
}

static class Islemler{
    static long Topla(int sayi1,int sayi2){
        return sayi1+sayi2;
    }
    static long Cikar(int sayi1,int sayi2){
        return sayi1-sayi2;
    }
}

enum Gunler 
{
    Pazartesi, 
    Sali, 
    Carsamba, 
    Persembe, 
    Cuma=23, 
    Cumartesi, 
    Pazar
}

enum HavaDurumu{
    Soguk=5,
    Normal=20,
    Sıcak=25,
    CokSıcak=30
}