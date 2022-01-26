public class Bitkiler: Canlilar{
    protected void FotosentezYapmak(){//protected sadece o sınıftan ve kalıtım alınan sınıflardan erişilebilmesine olanak sağlar.
        Console.WriteLine("Bitkiler fotosentez yapar."); 
    }
    public override void UyaranlaraTepki()
    {
        base.UyaranlaraTepki();
        Console.WriteLine("Bitkiler uyaranlara tepki verir.");
    }
}

public class TohumluBitkiler:Bitkiler{
    public TohumluBitkiler(){
        base.FotosentezYapmak();//protected ile tanımlanmış metotlara erişebilmek için constructor sınıfından base etmek gerekiyor.
        base.UyaranlaraTepki();
    }
    public void TohumlaCogalma(){
        Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
    }
}

 public class TohumsuzBitkiler:Bitkiler{
     public TohumsuzBitkiler(){
        base.FotosentezYapmak();
    }
    public void SporlaCogalma(){
        Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
    }
}