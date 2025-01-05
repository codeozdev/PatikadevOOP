namespace Week04_08;

public class BaseMakine
{
    protected DateTime UretimTarihi { get; init; }
    public int SeriNumarasi { get; init; }
    public string? Ad { get; init; }
    public string? Aciklama { get; init; }
    public string? IsletimSistemi { get; init; }


    public virtual void BilgileriYazdir()
    {
        Console.WriteLine(
            $"Ad: {Ad}, Açıklama: {Aciklama}, İşletim Sistemi: {IsletimSistemi}, Üretim Tarihi: {UretimTarihi}, Seri Numarası: {SeriNumarasi}");
    }
}