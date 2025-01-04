// Patika Kütüphane

var kitap1 = new KitaplarTablosu() {Ad = "Şeker Portakalı", YazarAdi = "José Mauro", YazarSoyadi = "De Vasconcelos", SayfaSayisi = 200, Yayinevi = "Can Yayınları"};
kitap1.ShowInfo();
var kitap2 = new KitaplarTablosu("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
kitap2.ShowInfo();

class KitaplarTablosu
{
    public string Ad { get; set; }
    public string YazarAdi { get; set; }
    public string YazarSoyadi { get; set; }
    public int SayfaSayisi { get; set; }
    public string Yayinevi { get; set; }
    public DateTime KayitTarihi { get; set; }

    public KitaplarTablosu()
    {
        KayitTarihi = DateTime.Now;
    }

    public KitaplarTablosu(string ad, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayinevi)
    {
        Ad = ad;
        YazarAdi = yazarAdi;
        YazarSoyadi = yazarSoyadi;
        SayfaSayisi = sayfaSayisi;
        Yayinevi = yayinevi;
        KayitTarihi = DateTime.Now;
    }

    public void ShowInfo()
    {
        Console.WriteLine(
            $"Ad: {Ad}, Yazar Adı: {YazarAdi}, Yazar Soyadı: {YazarSoyadi}, Sayfa Sayısı: {SayfaSayisi}, Yayınevi: {Yayinevi}, Kayıt Tarihi: {KayitTarihi}");
    }
}

/*
 Class
    - Classlar, bir nesnenin nasıl oluşturulacağını ve nasıl davranacağını tanımlar

# Properties
    - Property'ler, bir class'ın özelliklerini tanımlamak için kullanılır

# New
    - New anahtar kelimesi, bir class'ın instance'ını oluşturmak için kullanılır

# Constructors
    - Constructor'lar, bir class'ın instance alındığında çalışan metotlardır
    - Tanımlanmazsa default her class'ın bir constructor'ı vardır

 */