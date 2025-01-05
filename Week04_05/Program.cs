var kisi = new BaseKisi { Ad = "Banu", Soyad = "Yılmaz" };
kisi.ShowInfo();

var ogrenci = new Ogrenci { Ad = "Oğuzhan", Soyad = "Uğuz", OgrenciNo = 123 };
ogrenci.ShowInfo();

var ogretmen = new Ogretmen { Ad = "Sertan", Soyad = "Bozkuş", Maas = 5000 };
ogretmen.ShowInfo();

internal class BaseKisi
{
    public string? Ad { get; init; }
    public string? Soyad { get; init; }

    public virtual void ShowInfo() // ayni isimdeki methodlar kullanacagimiz icin virtual olarak tanimladik.
    {
        Console.WriteLine($"Ad: {Ad ?? "Unknown"}, Soyad: {Soyad ?? "Unknown"}");
    }
}

internal class Ogrenci : BaseKisi
{
    public int OgrenciNo { get; init; }

    public override void ShowInfo()
    {
        Console.WriteLine($"Ad: {Ad ?? "Unknown"}, Soyad: {Soyad ?? "Unknown"}, Ogrenci No: {OgrenciNo}");
    }
}

internal class Ogretmen : BaseKisi
{
    public double Maas { get; init; }

    public override void ShowInfo()
    {
        Console.WriteLine($"Ad: {Ad ?? "Unknown"}, Soyad: {Soyad ?? "Unknown"}, Maas: {Maas}");
    }
}