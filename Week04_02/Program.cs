/*
 Bu örnekte sizlerden bir Bebek sınıfı tanımlamanız isteniyor.

   Bebek sınıfının propertyleri -> Doğum Tarihi , Ad , Soyad

   Bebek sınıfı için 2 adet constructor tanımlayınız.

       1.si Default Constructor tarzında parametre almayan bir metot.

       2.si Ad ve Soyad parametrelerini alarak newleme işlemi sırasında değerleri propertylere atayan alternatif constructor.

       2 Constructor içinde ortak olarak bebek nesnesi oluşturulduğunda konsol ekranında bir " Ingaaaa " yazısı görülsün ve Doğum Tarihi o an olarak atansın.

   Tanımlama sonrasında her iki constructor ile de birer bebek nesnesi tanımlayarak özelliklerini konsol ekranına yazdırınız.

 */

var baby1 = new Baby();
baby1.ShowInfo();
var baby2 = new Baby("Ali", "Veli");
baby2.ShowInfo();

internal class Baby
{
    public DateTime BirthDate { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public Baby()
    {
        BirthDate = DateTime.Now;
        Console.WriteLine("Ingaaaa");
    }

    public Baby(string name, string surname)
    {
        Name = name;
        Surname = surname;
        BirthDate = DateTime.Now;
        Console.WriteLine("Ingaaaa");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Ad: {Name ?? "Bilinmiyor"}, Soyad: {Surname ?? "Bilinmiyor"}, Doğum Tarihi: {BirthDate}");
    }
}