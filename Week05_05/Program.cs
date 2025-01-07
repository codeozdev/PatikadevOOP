while (true)
{
    try
    {
        Console.Write("Lütfen bir sayı giriniz: ");
        var number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Girdiğiniz sayının karesi: {number * number}");
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Girdiğiniz değer sayısal bir değer değil. Lütfen bir sayı giriniz.");
    }
}