int[] sayiDizisi = new int[20];
int toplam = 0;

try
{
     for (int i = 0; i < sayiDizisi.Length; i++)
    {
        Console.Write("Lütfen {0}. sayıyı girin:", i+1);
        sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

foreach(var sayi in sayiDizisi){
    toplam+=sayi;
}
double ortalama = toplam / 20;
Console.WriteLine("Sayıların toplamı: " + toplam);
Console.WriteLine("Sayıların ortalaması: " + ortalama);

