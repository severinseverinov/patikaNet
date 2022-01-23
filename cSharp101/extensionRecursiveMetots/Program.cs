namespace extensionRecursiveMetots
{
    class Program
    {
        static void Main(string[] args){
            int recur=6;
            Console.WriteLine(recur.IsEventNumber());
            Console.WriteLine(recur.FibonacciSerisi());

            String isim="Sevgin SERBEST";
            bool b=isim.CheckSpaces();
            Console.WriteLine(b);

            if(b)
                Console.WriteLine(isim.RemoveWhiteSpaces());
        }
    }
    public static class MyExtensionClass
    {
        public static  bool IsEventNumber(this int value)
        {
        if(value%2==0)
            return true;
        else
            return false;
        }

        public static int FibonacciSerisi(this int sayi)
        {  
            if (sayi==0)
                return 0;
            else if (sayi==1)
                return 1;
            else
                return FibonacciSerisi(sayi-1)+FibonacciSerisi(sayi-2);
        }

        public static bool CheckSpaces(this String param){
            return param.Contains(" ");
        }

        public static String RemoveWhiteSpaces(this String param){
            String[] dizi=param.Split(" ");
            return String.Join("",dizi);
        }
    }
    
}
