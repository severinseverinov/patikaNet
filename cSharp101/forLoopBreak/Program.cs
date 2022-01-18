
for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
        continue;
    Console.WriteLine(i);
}

int tekToplam=0;
int ciftToplam=0;

for(int i=0;i<=2000;i++){
    if(i%2==1){
        tekToplam+=i;
    }else{
        ciftToplam+=i;
    }
}
Console.WriteLine("0-2000 arası çift sayıların toplamı : "+ciftToplam);
Console.WriteLine("0-2000 arası tek sayıların toplamı : "+tekToplam);