namespace Week04_08;

public class Telefon : BaseMakine
{
    public bool TrLisans { get; init; }

    public Telefon()
    {
        UretimTarihi = DateTime.Now;
    }


    public override void BilgileriYazdir()
    {
        base.BilgileriYazdir();
        Console.WriteLine($"Türkçe Lisans: {TrLisans} \n");
    }
}