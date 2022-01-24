using System.Collections;
/*
Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
*/

Console.WriteLine("***********************Soru 3***********************");
bool isPrime(int sayi)
{
    int counter = 0;
    for (int i = 2; i <= sayi; i++)
    {
        if(sayi % i == 0)
        {
            counter++;
        }
    }

    if (counter == 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}


Console.WriteLine("Lütfen 20 tane sayı giriniz: ");
int item = 0;
int counter = 0;
ArrayList arrayList = new ArrayList();
ArrayList primeNumber = new ArrayList();
ArrayList nonPrimeNumber = new ArrayList();

for(int i = 1; i<=20 + counter; i++)
{
    try
    {
        Console.Write(i + ". sayı: ");
        item = Convert.ToInt32(Console.ReadLine());

        if(item < 0)
        {
            Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            counter++;

        }
        else
        {
        arrayList.Add(item);
        }
        }
        catch (Exception)
            {
                counter++;
                Console.WriteLine("Lütfen bir sayı giriniz!!");
            }                
        }

foreach (int i in arrayList)
{
    if (isPrime(i))
    {
        primeNumber.Add(i);
    }
    else
    {
        nonPrimeNumber.Add(i);
    }
}

Console.WriteLine("------------------Sayılar--------------------------");
foreach (var i in arrayList)
{
    Console.WriteLine(i);
}

Console.WriteLine("Asal Sayılar");
foreach (var i in primeNumber)
{
    Console.WriteLine(i);
}

Console.WriteLine("Asal Olmayan Sayılar");
foreach (var i in nonPrimeNumber)
{
    Console.WriteLine(i);
}

Console.WriteLine("Asal ve asal olmayan sayıların ortalaması");

int primeSum = 0, nonPrimeSum = 0;
int primeCount = primeNumber.Count;
int nonPrimeCount = nonPrimeNumber.Count;

foreach (int i in primeNumber)
{
    primeSum += i;
}

Console.WriteLine("Asal sayıların ortalaması : " + (primeSum / primeCount));

foreach (int i in nonPrimeNumber)
{
    nonPrimeSum += i;
}

Console.WriteLine("Asal olmayan sayıların ortalaması : " + (nonPrimeSum / nonPrimeCount));

Console.WriteLine("Sıralanmış Listeler");

primeNumber.Sort();
nonPrimeNumber.Sort();
arrayList.Sort();

primeNumber.Reverse();
nonPrimeNumber.Reverse();
arrayList.Reverse();


Console.WriteLine("ArrayList");

foreach (var i in arrayList)
{
    Console.WriteLine(i);
}

Console.WriteLine("PrimeNumber");

foreach (var i in primeNumber)
{
    Console.WriteLine(i);
}

Console.WriteLine("nonPrimeNumber");

foreach (var i in nonPrimeNumber)
{
    Console.WriteLine(i);
}

/*
Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
*/
Console.WriteLine("***********************Soru 2***********************");
int[] numberList = new int[20];
Console.WriteLine("Lütfen 20 sayı giriniz: ");

for (int i = 0; i < 20; i++)
{
    try
    {
         Console.Write($"{i + 1}. sayı: ");
         numberList[i] = int.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {
        Console.WriteLine("Lütfen bir sayı giriniz! Hata:"+e);
    }
}

Array.Sort(numberList);

int averageMin = (numberList[0] + numberList[1] + numberList[2]) / 3;
int averageMax = (numberList[17] + numberList[18] + numberList[19]) / 3;
int averageSum = averageMax + averageMin;

Console.WriteLine("En küçük üç sayının ortalaması: " + averageMin);
Console.WriteLine("En büyük üç sayının ortalaması: " + averageMax);
Console.WriteLine("Ortalamalar toplamı: " + averageSum);

/*
Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
*/
Console.WriteLine("***********************Soru 3***********************");
char[] letters = { 'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü', 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

Console.Write("Bir cümle yazınız: ");
string words = Console.ReadLine();

char[] partOfWord = words.ToCharArray();

char[] temp = new char[partOfWord.Length];

for (int i = 0; i < partOfWord.Length; i++)
{
    for (int j = 0; j < letters.Length; j++)
    {
        if(partOfWord[i] == letters[j])
        {
            temp[i] = partOfWord[i];
        }
    }
}

Array.Sort(temp);

for (int i = 0; i < temp.Length; i++)
{
    Console.WriteLine(temp[i]);
}