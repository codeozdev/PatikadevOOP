/*
 Bu örnekte sizlerden bir Araba sınıfı oluşturmanız isteniyor.

Araba sınıfının özellikleri -> Marka, Model, Renk, Kapı Sayısı

Özelliklerimizden (Property) Kapı sayısı için kapsülleme işlemi yapmak istiyoruz.

Eğer bir Araba nesnesi oluşturulduğunda Kapı Sayısı için 2 veya 4 dışında bir değer atanmak isterse konsol ekranında bir uyarı mesajı yayınlayalım ve Kapı Sayısı değerini -1 olarak atayalım.

 */


var araba1 = new Araba(1);
Console.WriteLine($"Kapı Sayısı: {araba1.KapiSayisi}");

internal class Araba
{
    public string? Marka { get; set; }
    public string? Model { get; set; }
    public string? Renk { get; set; }
    private readonly int _kapiSayisi;

    public Araba(int kapiSayisi)
    {
        KapiSayisi = kapiSayisi; // (private _kapiSayisi) degiskene atamak yerine onun icin olusturulan property'i kullanarak atama yapilir.
    }

    public int KapiSayisi
    {
        get => _kapiSayisi;
        private init
        {
            if (value != 2 && value != 4)
            {
                Console.WriteLine("Kapı sayısı 2 veya 4 olmalıdır.");
                _kapiSayisi = -1;
            }
            else
            {
                _kapiSayisi = value;
            }
        }
    }
}