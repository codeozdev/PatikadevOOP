namespace Week04_08;

public class Bilgisayar : BaseMakine
{
    private readonly int _usbGirisSayisi;
    public bool BluetoothDurumu { get; init; }

    public Bilgisayar()
    {
        UretimTarihi = DateTime.Now;
    }

    public int UsbGirisSayisi
    {
        get => _usbGirisSayisi;
        init
        {
            if (value != 2 && value != 4)
            {
                Console.WriteLine("Usb sayısı 2 veya 4 olmalıdır.");
                _usbGirisSayisi = -1;
            }
            else
            {
                _usbGirisSayisi = value;
            }
        }
    }

    public override void BilgileriYazdir()
    {
        base.BilgileriYazdir();
        Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}, Bluetooth Durumu: {BluetoothDurumu}\n");
    }
}