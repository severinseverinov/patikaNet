namespace metots
{
    class Program{
    public static void Main(string[] args){
        int a=5;
        int b=10;

        Console.WriteLine(a+b);
        int sonuc=Topla(a,b);
        Console.WriteLine(sonuc);

        Metod ornek =new Metod();
        ornek.EkranaYazdir(Convert.ToString(sonuc));

        int sonuc2=ornek.ArttirTopla(ref a,ref b);
        Console.WriteLine(sonuc2);
    }

    static int Topla(int x, int y){
        return(x+y);
    }
    }
    class Metod{
        public void EkranaYazdir(String x){
            Console.WriteLine(x);
        }

        public int ArttirTopla(ref int x,ref int y){
            x++;
            y++;
            return x+y;
        }
    }
}
