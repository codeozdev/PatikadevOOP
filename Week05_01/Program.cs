// Array

var numbers = new int[10];

for (var i = 0; i < numbers.Length; i++)
{
    numbers[i] = i + 1;
}

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("Lütfen bir sayı giriniz: ");
var sayi = Convert.ToInt32(Console.ReadLine());

var newNumbers = new int[numbers.Length + 1];
newNumbers[10] = sayi;

foreach (var number in numbers.Reverse()) // Reverse methodu ile diziyi ters çeviriyoruz.
{
    Console.WriteLine(number);
}