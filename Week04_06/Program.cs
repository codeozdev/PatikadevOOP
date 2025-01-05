var kare = new Kare(5);
kare.ShowInfo();

var dikdortgen = new Dikdortgen(5, 10);
dikdortgen.ShowInfo();

var dikUcgen = new DikUcgen(5, 10);
dikUcgen.ShowInfo();

internal abstract class BaseGeometrikSekil
{
    protected double Genislik { get; init; }
    protected double Yukseklik { get; init; }

    public abstract double AlanHesapla();
    public abstract void ShowInfo();
}

internal class Kare : BaseGeometrikSekil
{
    public Kare(double kare)
    {
        Genislik = Yukseklik = kare;
    }

    public override double AlanHesapla()
    {
        return Genislik * Yukseklik;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Kare Alanı: {AlanHesapla()}");
    }

}

internal class Dikdortgen : BaseGeometrikSekil
{
    public Dikdortgen(double genislik, double yukseklik)
    {
        Genislik = genislik;
        Yukseklik = yukseklik;
    }

    public override double AlanHesapla()
    {
        return Genislik * Yukseklik;
    }
    
    public override void ShowInfo()
    {
        Console.WriteLine($"Dikdörtgen Alanı: {AlanHesapla()}");
    }
}

internal class DikUcgen : BaseGeometrikSekil
{
    public DikUcgen(double genislik, double yukseklik)
    {
        Genislik = genislik;
        Yukseklik = yukseklik;
    }

    public override double AlanHesapla()
    {
        return Genislik * Yukseklik / 2;
    }
    
    public override void ShowInfo()
    {
        Console.WriteLine($"Dik Üçgen Alanı: {AlanHesapla()}");
    }
}