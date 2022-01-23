// Ödev 1 - 1. soru
Console.Write("Girilecek sayı adedi: ");
int n = int.Parse(Console.ReadLine());
int[] dizi = new int[n];
            
for (int i = 0; i < n; i++)
{
    Console.Write("Lütfen {0}. elemanı girin ",i+1);
    dizi[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Çift sayılar: ");
foreach (var item in dizi)
{
    if(item % 2 == 0)
    Console.WriteLine(item);

}

//2. soru

Console.Write("Girilecek sayı adedi: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Bölüne yada eşit olacak sayı : ");
int m = int.Parse(Console.ReadLine());
int[] dizi = new int[n];
        
for (int i = 0; i < n; i++)
{
    Console.Write("Lütfen {0}. elemanı girin ",i+1);
    dizi[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Girilen sayılardan {0} ile tam bölünen ya da eşit olanlar ",m);
foreach (var item in dizi)
{
    if(item % m == 0 || item == m)
    Console.WriteLine(item);
}

// 3. soru
Console.WriteLine("Lütfen kaç adet kelime girileceğini yazın: ");
int n = int.Parse(Console.ReadLine());
string[] words = new string[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Lütfen {0}. kelimeyi girin: ",i+1);
    words[i] = Console.ReadLine();
}
Array.Reverse(words);
Console.WriteLine("Sondan başa doğru giriş yaptığınız kelimeler: ");
foreach (var item in words)
{
    Console.WriteLine(item);
}

//4. soru

Console.Write("Lütfen bir cümle yazın: ");
string sentence = Console.ReadLine();

string[] word = sentece.Split(" ");
    

int senLen = word.Length;
 Console.Write("Kelime sayısı: " + senLen);

int harf = 0;
char[] trim = {'!','.',',',';'};
foreach (var item in word)
{
    string res = item.Trim(trim);
    harf += res.Length;
}
Console.WriteLine("Harf sayısı: " + harf);

