namespace metotOverload
{
    class Program
    {
        public static void Main(string[] args){
            String sayi="999";
            int outSayi;

            bool sonuc=int.TryParse(sayi,out outSayi); //yukarıda tanımlanmazsa içerde int.TryParse(sayi,out int outSayi); olarak tanımlanabilir.
            //TryParse ile tip dönüşümü gerçekleştirilmeye çalışılır olmaz ise bir hata vermez.
            if(sonuc){
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }else{
                Console.WriteLine("İşlem başarısız!");
            }
            Metotlar instance=new Metotlar();
            //metoda değer gönredikten sonra out int ile beraber metottan gelen sonucu bir değişkene aktarılabilir.
            instance.Topla(4,5,out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            String isim="Sevgin SERBEST";
            int yas=36;
            instance.Yazdir(isim);
            instance.Yazdir(yas);

        }

        class Metotlar{
            public void Topla(int a,int b,out int toplam){
                //Metot tanımlanırken return yerine referanslardan sonra out ile beraber değişken tipiyle beraber ifade edilebilir.
                toplam=a+b;
            }
            //aynı isimli fakat farklı değişken tipleri yada farklı sayıda değer almalarına overloading denir.
            public void Yazdir(String ad){
                Console.WriteLine(ad);
            }
            public void Yazdir(int yas){
                Console.WriteLine(yas);
            }
        }
    }
    
}
