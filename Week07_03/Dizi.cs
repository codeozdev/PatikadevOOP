namespace Week07_03;

public class Dizi
{
    public string? DiziAdi { get; }
    private int YapimYili { get; }
    public string? DiziTuru { get; }
    private int YapimaBaslanmaYili { get; }
    public List<string>? Yonetmenler { get; }
    private string? Platform { get; }

    public Dizi(string? diziAdi, int yapimYili, string? diziTuru, int yapimaBaslanmaYili, List<string>? yonetmenler,
        string? platform)
    {
        DiziAdi = diziAdi;
        YapimYili = yapimYili;
        DiziTuru = diziTuru;
        YapimaBaslanmaYili = yapimaBaslanmaYili;
        Yonetmenler = yonetmenler;
        Platform = platform;
    }

    public void DiziInfo()
    {
        Console.WriteLine($"Dizi Adı: {DiziAdi}");
        Console.WriteLine($"Yapım Yılı: {YapimYili}");
        Console.WriteLine($"Dizi Türü: {DiziTuru}");
        Console.WriteLine($"Yapıma Başlama Yılı: {YapimaBaslanmaYili}");
        Console.Write("Yönetmenler: ");
        Console.WriteLine(Yonetmenler is { Count: > 0 } ? string.Join(", ", Yonetmenler) : "Yönetmen bilgisi yok.");
        Console.WriteLine($"Platform: {Platform}");
        Console.WriteLine(new string('-', 50));
    }
}