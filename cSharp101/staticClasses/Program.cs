Console.WriteLine("Çalışılan Sayısı : {0}",Calisan.CalisanSayisi);
Calisan emp1=new Calisan("Sevgin","SERBEST","Arge");
Calisan emp2=new Calisan("Elif","SERBEST","Arge");
Calisan emp3=new Calisan("Ali","VELİ","Bakım");
Console.WriteLine("Çalışan sayısı : {0}",Calisan.CalisanSayisi);


Islemler.Topla(25,85);// static olarak tanımlana sınıflara erişim direk olur yeni bir nesne tanımlamaya gerek yok.



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