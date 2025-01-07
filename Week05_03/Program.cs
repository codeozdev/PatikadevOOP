List<string?> coffees = [];

for (var i = 0; i < 5; i++)
{
    Console.Write("Kahve ismi giriniz: ");
    coffees.Add(Console.ReadLine());
}

Console.WriteLine("Girilen Kahve İsimleri: ");

foreach (var coffee in coffees)
{
    Console.WriteLine(coffee);
}