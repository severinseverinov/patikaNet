public class Hayvanlar: Canlilar{
    public void SuruHalindeHareket(){
        Console.WriteLine("Hayvanlar sürüler halinde hareket eder."); 
    }

    public override void UyaranlaraTepki()
    {
        base.UyaranlaraTepki();//Bu gelmesi gerekir. Orjinal hali implement edilir.
        Console.WriteLine("Hayvanlar temasa tepki verir.");
    }
}

public class Kus:Hayvanlar{
    public void Ucmak(){
        Console.WriteLine("Kuşlar uçar");
    }
}

public class Ordek:Hayvanlar{
    public void Yuzmek(){
        Console.WriteLine("Ördekler yüzer");
    }
}
