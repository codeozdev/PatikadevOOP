using Week05_06;

List<Araba> arabalar = [];

while (true)
{
    try
    {
        Console.WriteLine("Araba üretmek istiyor musunuz? (e/h)");
        var cevap = Console.ReadLine()?.ToLower();
        if (cevap != "e" && cevap != "h")
        {
            throw new ArgumentException("Geçersiz bir değer girdiniz. Lütfen e veya h giriniz.");
        }

        if (cevap == "h") break;

        Console.Write("Serinumarasını giriniz: ");
        var seriNumarasi = Convert.ToInt32(Console.ReadLine());

        Console.Write("Marka giriniz: ");
        var marka = Console.ReadLine();

        Console.Write("Model giriniz: ");
        var model = Console.ReadLine();

        Console.Write("Renk giriniz: ");
        var renk = Console.ReadLine();

        int kapiSayisi;
        while (true)
        {
            Console.Write("Kapı sayısını giriniz: ");
            kapiSayisi = Convert.ToInt32(Console.ReadLine());

            if (kapiSayisi is >= 2 and <= 4)
                break;
            Console.WriteLine("Kapı sayısı 2 ile 4 arasında olmalıdır. Lütfen tekrar giriniz.");
        }


        var araba = new Araba
        {
            SeriNumarasi = seriNumarasi,
            Marka = marka,
            Model = model,
            Renk = renk,
            KapiSayisi = kapiSayisi
        };

        arabalar.Add(araba);
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
    }
}

Console.WriteLine("\nAraba Listesi:");
foreach (var araba in arabalar)
{
    Console.WriteLine(
        $"Seri Numarası: {araba.SeriNumarasi}, Marka: {araba.Marka}, Model: {araba.Model}, Renk: {araba.Renk}, Kapı Sayısı: {araba.KapiSayisi}, Üretim Tarihi: {araba.UretimTarihi}");
}