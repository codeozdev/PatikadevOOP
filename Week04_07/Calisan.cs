namespace Week04_07;

public abstract class Calisan
{
    protected string? Ad { get; init; }
    protected string? Soyad { get; init; }
    protected string? Departman { get; init; }

    public abstract void Gorev();
}

public class YazilimGelistirici : Calisan
{
    public YazilimGelistirici(string ad, string soyad, string departman)
    {
        Ad = ad;
        Soyad = soyad;
        Departman = departman;
    }

    public override void Gorev()
    {
        Console.WriteLine($"Adım {Ad} soyadım {Soyad} {Departman}'de çalışıyorum.");
    }
}

public class ProjeYoneticisi : Calisan
{
    public ProjeYoneticisi(string ad, string soyad, string departman)
    {
        Ad = ad;
        Soyad = soyad;
        Departman = departman;
    }

    public override void Gorev()
    {
        Console.WriteLine($"Adım {Ad} soyadım {Soyad} {Departman}'de çalışıyorum.");
    }
}

public class SatisTemsilcisi : Calisan
{
    public SatisTemsilcisi(string ad, string soyad, string departman)
    {
        Ad = ad;
        Soyad = soyad;
        Departman = departman;
    }

    public override void Gorev()
    {
        Console.WriteLine($"Adım {Ad} soyadım {Soyad} {Departman}'da çalışıyorum.");
    }
}