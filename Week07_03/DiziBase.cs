namespace Week07_03;

public class DiziBase
{


    public string? DiziAdi { get; set; }
    public string? DiziTuru { get; set; }
    public List<string>? Yonetmenler { get; set; }
    
    public DiziBase(string? diziAdi, string? diziTuru, List<string>? yonetmenler)
    {
        DiziAdi = diziAdi;
        DiziTuru = diziTuru;
        Yonetmenler = yonetmenler;
    }

}