public /*sealed*/ class Canlilar {//Bu sınıftan türetilme olmaması için kullanılır.
//sealed yazılırsa sadece kullanılabilir, türetilemez!
    public void Beslenme(){
        Console.WriteLine("Canlılar beslenir.");        
    }

    public void Solunum(){
        Console.WriteLine("Canlılar solunum yapar."); 
    }

    public void Bosaltim()
    {
        Console.WriteLine("Canlılar boşaltım Yapar."); 
    }

    public virtual void UyaranlaraTepki(){ //override edebilmek için 'virtual' yazmak gerekir.
        Console.WriteLine("Base Sınıf - Uyaranlara tepki.");
    }
}