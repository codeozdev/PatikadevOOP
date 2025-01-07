namespace Week05_06;

public class Araba
{
    public DateTime UretimTarihi { get; set; } = DateTime.Now;
    public int SeriNumarasi { get; init; }
    public string? Marka { get; init; }
    public string? Model { get; init; }
    public string? Renk { get; init; }
    public int KapiSayisi { get; init; }
}