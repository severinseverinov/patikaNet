
Console.WriteLine(DateTime.Now);//şuanki tarihi ve saati getirir.
Console.WriteLine(DateTime.Now.Date);//bugünün tarihi
Console.WriteLine(DateTime.Now.Day);//bugün
Console.WriteLine(DateTime.Now.Month);//buay
Console.WriteLine(DateTime.Now.Year);//buyıl
Console.WriteLine(DateTime.Now.Hour);//Şaunki saat
Console.WriteLine(DateTime.Now.Minute);//Şuanki dakika
Console.WriteLine(DateTime.Now.Second);//Şuanki saniye

Console.WriteLine(DateTime.Now.DayOfWeek);//haftanın hangi günündeyiz.
Console.WriteLine(DateTime.Now.DayOfYear);//Yılın kaçıncı günündeyiz.

Console.WriteLine(DateTime.Now.ToLongDateString());//şuanki tarih uzun olarak string türünden getirir.
Console.WriteLine(DateTime.Now.ToShortDateString());//bugünün tarihini kısa şekilde string tipinden getirir.

Console.WriteLine(DateTime.Now.ToLongTimeString());//şaunki saati uzun şekilde string tipinde döndürür.
Console.WriteLine(DateTime.Now.ToShortTimeString());//şuanki saati kısa şeikilde string tipinde döndürür.

Console.WriteLine(DateTime.Now.AddDays(2));//Bugünün tarihine 2 gün ekler.
Console.WriteLine(DateTime.Now.AddHours(2));//şuanki saate 2 saat ekler.
Console.WriteLine(DateTime.Now.AddSeconds(200));//şuanki saniyeye 200 saniye ekler.
Console.WriteLine(DateTime.Now.AddMonths(2));//bu aya 2 ay ekler.

//Datetime formatlama
Console.WriteLine(DateTime.Now.ToString("dd"));//ayın kaçıncı günü : 24
Console.WriteLine(DateTime.Now.ToString("ddd"));//Haftanın hangi günü kısa : Mon
Console.WriteLine(DateTime.Now.ToString("dddd"));//Haftanın hangi günü uzun : Monday


Console.WriteLine(DateTime.Now.ToString("MM"));//yılın kaçıncı ayı : 01
Console.WriteLine(DateTime.Now.ToString("MMM"));//Yılın hangi ayı kısa : Jan
Console.WriteLine(DateTime.Now.ToString("MMMM"));//Yılın hangi ayı uzun : January

Console.WriteLine(DateTime.Now.ToString("yy"));//yılın son iki rakamı : 22
Console.WriteLine(DateTime.Now.ToString("yyyy"));//yılı : 2022

//------------------Math Kütüphanesi------------------
Console.WriteLine(Math.Abs(-25));//Mutlak değer
Console.WriteLine(Math.Sin(1));//sinüs
Console.WriteLine(Math.Cos(1));//cosinüs
Console.WriteLine(Math.Tan(1));//tan

Console.WriteLine(Math.Ceiling(22.3));//22.3ten sonraki tam sayı getirir (yukarı yuvarla)=> 23
Console.WriteLine(Math.Floor(22.7));//22.3 tam kısmını alır (aşağı yuvarla)=> 22
Console.WriteLine(Math.Round(22.6));//22.3 yuvarlama işlemine tabi tutar => 23

Console.WriteLine(Math.Max(2,6));//iki sayıdan büyük olanı döndürür.
Console.WriteLine(Math.Min(2,6));

Console.WriteLine(Math.Pow(3,4));//üs alma
Console.WriteLine(Math.Sqrt(16));//karekök alma
Console.WriteLine(Math.Log(9));//logaritma
Console.WriteLine(Math.Exp(2));// e üzeri 2
