/*
 Rastgele 10 adet sayıdan oluşan bir liste oluşturunuz. Bu liste üzerinden aşağıdaki linq sorgularını çalıştırarak konsol ekranına istenilenleri yazdırınız.

   Çift olan sayılar

   Tek olan sayılar

   Negatif sayılar

   Pozitif Sayılar

   15'ten büyük ve 22'den küçük sayılar

   Listedeki her bir sayının karesi (Bunun için yeni bir liste oluşturup yazdırabilirsiniz.)

 */


var rnd = new Random();
List<int> sayilar = [];
for (var i = 0; i <= 10; i++)
{
    var sayi = rnd.Next(-100, 100);
    sayilar.Add(sayi);
}

var evenNumbers = sayilar.Where(p => p % 2 == 0);
var oddNumbers = sayilar.Where(p => p % 2 != 0);
var negativeNumbers = sayilar.Where(p => p < 0);
var positiveNumbers = sayilar.Where(p => p > 0);
var between15And22 = sayilar.Where(p => p is > 15 and < 22);
var squares = sayilar.Select(p => p * p).ToList();

foreach (var s in squares)
{
    Console.WriteLine(s);
}