using System;
using System.Collections.Generic;
using System.Linq;

namespace degiskenler // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            object o1="Sevgin SERBEST";

            String str1=String.Empty;
            str1=str1+"Sevgin SERBEST";

            Console.WriteLine(str1);

            bool b1=10>0;
            Console.WriteLine(b1);

            String str20="Sevgin SERBEST";
            int yas=36;

            String newStr20=str20+" yas: "+yas.ToString();
            Console.WriteLine(newStr20);

            String tarih=DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(tarih);
        }
    }
}

