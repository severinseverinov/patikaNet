﻿// try
// {
//     int a = int.Parse(Console.ReadLine());
//     int b = int.Parse(Console.ReadLine());
//     int c = a+b;
//     Console.WriteLine(c);

// }
// catch(Exception ex)
// {
//     Console.WriteLine("Bir Hata Oluştu: "+ ex.Message);
// }
// finally
// {
//     Console.WriteLine("İşlem tamamlandı.");
// }

try
{
     int a=int.Parse("Test");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Boş değer girilemez.");
    Console.WriteLine(ex);
}
catch (FormatException ex)
{
    Console.WriteLine("Veri tipi uygun değil.");
    Console.WriteLine(ex);
}
finally{
    Console.WriteLine("Finally bloğu çalıştı.");
}