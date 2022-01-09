// See https://aka.ms/new-console-template for more information
Console.WriteLine("****** Implicit Conversion ******");
short a=25;
int b=a;
Console.WriteLine(b);


Console.WriteLine("****** Explicit Conversion ******");

long c=120050;
int d=(int)c;
Console.WriteLine(d);

String str1="120";
sbyte by1=Convert.ToSByte(str1);
Console.WriteLine(by1);

String str2="220";
decimal dc1=Convert.ToDecimal(str2);
Console.WriteLine(dc1);


decimal dc2=120.25M;
float flt1=(float)dc2;
Console.WriteLine(flt1);

String str4="220";
byte byt2=byte.Parse(str4);
Console.WriteLine(byt2);

str4=Convert.ToDateTime("12.02.2021");