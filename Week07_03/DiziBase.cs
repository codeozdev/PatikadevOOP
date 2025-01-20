namespace Week07_03;

public class DiziBase
{
    public string? DiziAdi { get; }
    public string? DiziTuru { get; }
    public List<string>? Yonetmenler { get; }

    public DiziBase(string? diziAdi, string? diziTuru, List<string>? yonetmenler)
    {
        DiziAdi = diziAdi;
        DiziTuru = diziTuru;
        Yonetmenler = yonetmenler;
    }
}