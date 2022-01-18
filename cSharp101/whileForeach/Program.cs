int sayac = 1;
while (sayac <= 5)
{
    Console.WriteLine(sayac);
    sayac++;
}

char charakter='a';
while(charakter<='z'){
    if(charakter=='z'){
        Console.Write(charakter);
    }else{
    Console.Write(charakter+", ");
    }
    charakter++;

}
Console.WriteLine("");

int[] sayiDizisi = {2,4,5,1,2,4};
int toplam = 0 ;

foreach(int i in sayiDizisi)
{
    toplam += i ;
}
Console.WriteLine("Dizi içindeki sayıların toplamı : "+toplam);

String[] arabalar={"BMW","Ford","Toyota","Nissan"};
foreach(var araba in arabalar){
    Console.WriteLine(araba);
}