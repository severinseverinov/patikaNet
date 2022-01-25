Ogrenci ogr1=new Ogrenci("Sevgin","Serbest",37,4,1);
ogr1.OgrenciBilgiGetir();
Ogrenci ogr2=new Ogrenci("Elif","Serbest",36,3,2);
ogr2.OgrenciBilgiGetir();
ogr2.SinifAtlat();
ogr2.OgrenciBilgiGetir();
Ogrenci ogr3=new Ogrenci("Ali","Veli",37,1,3);
ogr3.OgrenciBilgiGetir();
ogr3.SinifDusur();
ogr3.OgrenciBilgiGetir();

class Ogrenci{
    private String isim;
    private String soyIsim;
    private int ogrenciNo;
    private int sinif;
    private int ogr;


    public Ogrenci(){}

    public Ogrenci(string ısim, string soyIsim, int ogrenciNo, int sinif,int ogr)
    {
        this.Isim = ısim;
        this.SoyIsim = soyIsim;
        this.OgrenciNo = ogrenciNo;
        this.Sinif = sinif;
        this.Ogr=ogr;

    }

    public string Isim { get => isim; set => isim = value; }
    public string SoyIsim { get => soyIsim; set => soyIsim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif { get => sinif; 
    
    set { if(value<1){
        Console.WriteLine("Sınıf en az 1 olabilir."); sinif=1;
        }else{sinif = value;}
         
        }}
    public int Ogr { get => ogr; set => ogr = value; }

    public void OgrenciBilgiGetir(){
        Console.WriteLine("*********** {0}. Öğrenci Bilgileri***********",this.ogr);
        Console.WriteLine("Öğrencinin adı : {0}",this.isim);
        Console.WriteLine("Öğrencinin soyadı : {0}",this.soyIsim);
        Console.WriteLine("Öğrencinin okul no : {0}",this.ogrenciNo);
        Console.WriteLine("Öğrencinin sınıfı : {0}",this.sinif);
    }

    public void SinifAtlat(){
        this.Sinif+=1;
    }
    public void SinifDusur(){
        this.Sinif=Sinif-1;
    }
}