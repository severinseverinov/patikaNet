using System;

namespace operatorler
{
    class Proram{
        static void Main(String[] args){
            int x=36;
            x|=2;
            Console.WriteLine(x);

            if(true^false){
                Console.WriteLine("true");
            }else{
                Console.WriteLine("false");
            }
        }
    }
}
