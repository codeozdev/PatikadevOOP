namespace Week05_04;

public class Film
{
    public double ImdbPuani { get; set; }
    public string? FilmAdi { get; set; }

    public Film(double imdbPuani, string? filmAdi)
    {
        ImdbPuani = imdbPuani;
        FilmAdi = filmAdi;
    }
}