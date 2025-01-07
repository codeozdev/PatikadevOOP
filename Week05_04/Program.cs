using Week05_04;

List<Film> films = [];

while (true)
{
    double imdbScore;
    while (true)
    {
        Console.Write("IMDB puanını giriniz: ");
        if (double.TryParse(Console.ReadLine(), out imdbScore) && imdbScore is >= 0.0 and <= 10.0) break;

        Console.WriteLine("Lütfen 0 ile 10 arasında geçerli bir sayı giriniz.");
    }


    string? filmName;
    while (true)
    {
        Console.Write("Film adı giriniz: ");
        filmName = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(filmName)) break;

        Console.WriteLine("Film adı boş geçilemez. Lütfen geçerli bir film adı giriniz.");
    }

    films.Add(new Film(imdbScore, filmName));


    Console.Write("Yeni bir film eklemek istiyor musunuz? (e/h): ");
    var answer = Console.ReadLine()?.ToLower();

    if (answer == "h") break;
}

Console.WriteLine("\nFilm Listesi:");
foreach (var film in films)
{
    Console.WriteLine($"IMDB Puanı: {film.ImdbPuani}, Film Adı: {film.FilmAdi}");
}

Console.WriteLine("Imdb puanı 4 ile 9 arasında olan filmler: ");
foreach (var film in films.Where(f => f.ImdbPuani is >= 4.0 and <= 9.0))
{
    Console.WriteLine($"IMDB Puanı: {film.ImdbPuani}, Film Adı: {film.FilmAdi}");
}

Console.WriteLine("İsmi 'A' ile başlayan filmler ve imdb puanları");
foreach (var film in films.Where(f => f.FilmAdi?.StartsWith("A", StringComparison.OrdinalIgnoreCase) == true))
{
    Console.WriteLine($"IMDB Puanı: {film.ImdbPuani}, Film Adı: {film.FilmAdi}");
}