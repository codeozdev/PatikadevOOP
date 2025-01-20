using Week07_03;

// List<Dizi> ornekListe =
// [
//     new Dizi
//     {
//         DiziAdi = "Friends",
//         YapimYili = 1994,
//         DiziTuru = "Komedi",
//         YapimaBaslanmaYili = 1993,
//         Yonetmenler = ["David Crane", "Marta Kauffman"],
//         Platform = "Netflix"
//     },
//     new Dizi
//     {
//         DiziAdi = "The Office",
//         YapimYili = 2005,
//         DiziTuru = "Komedi",
//         YapimaBaslanmaYili = 2004,
//         Yonetmenler = ["Greg Daniels"],
//         Platform = "Peacock"
//     },
//     new Dizi
//     {
//         DiziAdi = "Breaking Bad",
//         YapimYili = 2008,
//         DiziTuru = "Dram",
//         YapimaBaslanmaYili = 2007,
//         Yonetmenler = ["Vince Gilligan"],
//         Platform = "Netflix"
//     },
//     new Dizi
//     {
//         DiziAdi = "Stranger Things",
//         YapimYili = 2016,
//         DiziTuru = "Bilim Kurgu",
//         YapimaBaslanmaYili = 2015,
//         Yonetmenler = ["Matt Duffer", "Ross Duffer"],
//         Platform = "Netflix"
//     },
//     new Dizi
//     {
//         DiziAdi = "Game of Thrones",
//         YapimYili = 2011,
//         DiziTuru = "Fantastik",
//         YapimaBaslanmaYili = 2010,
//         Yonetmenler = ["David Benioff", "D.B. Weiss"],
//         Platform = "HBO"
//     },
//     new Dizi
//     {
//         DiziAdi = "The Crown",
//         YapimYili = 2016,
//         DiziTuru = "Dram",
//         YapimaBaslanmaYili = 2014,
//         Yonetmenler = ["Peter Morgan"],
//         Platform = "Netflix"
//     },
//     new Dizi
//     {
//         DiziAdi = "Narcos",
//         YapimYili = 2015,
//         DiziTuru = "Suç",
//         YapimaBaslanmaYili = 2014,
//         Yonetmenler = ["Andrés Baiz", "Jose Padilha"],
//         Platform = "Netflix"
//     },
//     new Dizi
//     {
//         DiziAdi = "The Mandalorian",
//         YapimYili = 2019,
//         DiziTuru = "Bilim Kurgu",
//         YapimaBaslanmaYili = 2018,
//         Yonetmenler = ["Jon Favreau"],
//         Platform = "Disney+"
//     },
//     new Dizi
//     {
//         DiziAdi = "Sherlock",
//         YapimYili = 2010,
//         DiziTuru = "Suç",
//         YapimaBaslanmaYili = 2009,
//         Yonetmenler = ["Mark Gatiss", "Steven Moffat"],
//         Platform = "BBC One"
//     },
//     new Dizi
//     {
//         DiziAdi = "The Witcher",
//         YapimYili = 2019,
//         DiziTuru = "Fantastik",
//         YapimaBaslanmaYili = 2018,
//         Yonetmenler = ["Lauren Schmidt Hissrich"],
//         Platform = "Netflix"
//     }
// ];

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