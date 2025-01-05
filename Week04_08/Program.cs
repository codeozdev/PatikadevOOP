using Week04_08;


while (true)
{
    Console.Write("Telefon üretmek için 1'e Bilgisayar üretmek için 2'ye basınız: ");
    var secim = Console.ReadLine();

    switch (secim)
    {
        case "1":
            Console.WriteLine("Telefon üretiliyor.\n");
            var telefon = new Telefon
            {
                Ad = "Samsung",
                Aciklama = "Galaxy S23",
                IsletimSistemi = "Android",
                SeriNumarasi = 123,
                TrLisans = true
            };

            telefon.BilgileriYazdir();
            break;
        case "2":
            Console.WriteLine("Bilgisayar üretiliyor.\n");
            var bilgisayar = new Bilgisayar
            {
                Ad = "Asus",
                Aciklama = "Zenbook",
                IsletimSistemi = "Windows",
                SeriNumarasi = 123,
                UsbGirisSayisi = 1,
                BluetoothDurumu = true
            };

            bilgisayar.BilgileriYazdir();
            break;
        default:
            Console.WriteLine("Geçersiz seçim.");
            break;
    }

    Console.Write("Başka bir ürün üretmek ister misiniz? (E/H)");
    var cevap = Console.ReadLine()?.ToLower();
    if (cevap == "h")
    {
        Console.WriteLine("İyi günler");
        break;
    }
}