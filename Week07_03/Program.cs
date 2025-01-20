using Week07_03;

List<Dizi> diziListesi = [];
if (diziListesi == null) throw new ArgumentNullException(nameof(diziListesi));
while (true)
{
    string? diziAdi;
    while (true)
    {
        Console.Write("Dizi adı giriniz: ");
        diziAdi = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(diziAdi)) break;

        Console.WriteLine("Dizi adı boş geçilemez.");
    }

    int yapimYili;
    while (true)
    {
        Console.Write("Yapım yılını giriniz: ");
        var input = Console.ReadLine();
        if (int.TryParse(input, out yapimYili) && yapimYili is >= 1900 and <= 2025) break;
        Console.WriteLine("Geçerli bir sayı giriniz. Yapım yılı 1900 ve 2025 arasında olmalıdır.");
    }

    string[] validGenres = ["komedi", "polisiye", "dram", "tarihi"];
    string? diziTuru;
    while (true)
    {
        Console.Write("Dizi türünü giriniz (Komedi, Polisiye, Dram, Tarihi): ");
        diziTuru = Console.ReadLine()?.ToLower();
        if (!string.IsNullOrWhiteSpace(diziTuru) && validGenres.Contains(diziTuru)) break;
        Console.WriteLine("Lütfen geçerli bir dizi türü giriniz (Komedi, Polisiye, Dram, Tarihi).");
    }


    int yapimaBaslanmaYili;
    while (true)
    {
        Console.Write("Yapıma başlama yılını giriniz: ");
        var input = Console.ReadLine();
        if (int.TryParse(input, out yapimaBaslanmaYili) && yapimaBaslanmaYili is >= 1900 and <= 2025) break;
        Console.WriteLine("Yapıma başlama yılı 1900 ve 2025 arasında olmalıdır.");
    }

    List<string> yonetmenler = [];
    while (true)
    {
        Console.Write("Yönetmenleri giriniz: ");
        var yonetmen = Console.ReadLine();

        if (yonetmen == "q") break;
        if (!string.IsNullOrWhiteSpace(yonetmen))
        {
            yonetmenler.Add(yonetmen);
        }
        else
        {
            Console.WriteLine("Yönetmen ismi boş olamaz.");
        }

        Console.WriteLine("Yönetmen eklemeyi bitirmek için 'q' tuşuna basınız.");
    }


    string? platform;
    while (true)
    {
        Console.Write("Platform türünü giriniz: ");
        platform = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(platform)) break;
        Console.WriteLine("Platform türü boş geçilemez.");
    }


    diziListesi.Add(new Dizi(diziAdi, yapimYili, diziTuru, yapimaBaslanmaYili, yonetmenler, platform));

    Console.Write("Yeni bir film eklemek istiyor musunuz? (e/h): ");
    var answer = Console.ReadLine()?.ToLower();


    if (answer == "h")
    {
        foreach (var dizi in diziListesi)
        {
            dizi.DiziInfo();
        }

        break;
    }
}

// Komedi türündeki dizileri filtreleyip yeni liste oluşturuyoruz
Console.WriteLine("Komedi türündeki diziler:");
var komediDizileri = diziListesi
    .Where(d => d.DiziTuru != null && d.DiziTuru.Equals("komedi", StringComparison.OrdinalIgnoreCase))
    .Select(d => new DiziBase(d.DiziAdi!, d.DiziTuru!, d.Yonetmenler ?? []))
    .ToList();

foreach (var dizi in komediDizileri)
{
    Console.WriteLine($"Dizi Adı: {dizi.DiziAdi}");
    Console.WriteLine($"Dizi Türü: {dizi.DiziTuru}");

    Console.Write("Yönetmenler: ");
    if (dizi.Yonetmenler != null)
        foreach (var yonetmen in dizi.Yonetmenler)
        {
            Console.Write(yonetmen);
            if (yonetmen != dizi.Yonetmenler.Last())
            {
                Console.Write(", ");
            }
        }

    Console.WriteLine("\n----------------------------");
}