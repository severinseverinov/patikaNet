Calisan emp1=new Calisan(){
    isim="Sevgin",
    soyIsim="Serbest",
    no=3258745,
    departman="Arge"
};
Console.WriteLine("*** Çalışan 1 ***");
emp1.calisanBilgileri();

Calisan emp2=new Calisan();
emp2.isim="Elif";
emp2.soyIsim="Serbest";
emp2.no=454654;
emp2.departman="İka";
Console.WriteLine("*** Çalışan 2 ***");
emp2.calisanBilgileri();

Calisan emp3=new Calisan("Ayşe","Kara",234588,"Arge");
Console.WriteLine("*** Çalışan 3 ***");
emp3.calisanBilgileri();

class Calisan{
    public String isim;
    public String soyIsim;
    public int no;
    public String departman;

    public Calisan(String isim, String soyIsim, int no, String departman){
        this.isim=isim;
        this.soyIsim=soyIsim;
        this.no=no;
        this.departman=departman;
    }
    public Calisan(){
        
    }

    public void calisanBilgileri(){
        Console.WriteLine("Çalışan adı : {0}",isim);
        Console.WriteLine("Çalışan soyadı : {0}",soyIsim);
        Console.WriteLine("Çalışan numarası : {0}",no);
        Console.WriteLine("Çalışan departmanı : {0}",departman);
    }
}
