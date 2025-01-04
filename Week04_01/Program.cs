/*
 Bir okul yönetim sistemi yazıyorsunuz.

   Öğrencilerin ve öğretmenlerin bilgilerini yönetmek için Person adında genel bir sınıf oluşturmanız isteniyor. Bu sınıfın özellikleri şunlar olmalı: Ad, Soyad, Doğum Tarihi.

      Person adında bir sınıf oluşturun ve bu özellikleri içeren public property'ler (get/set) tanımlayın.

      Main metodu içinde, bu sınıftan birkaç öğrenci ve öğretmen nesnesi oluşturun ve bilgilerini konsola yazdırın.
 */


var student1 = new Person { Name = "Banu", Surname = "Yıldız", BirthDate = new DateTime(2000, 1, 1) };
var teacher1 = new Person { Name = "Ümit", Surname = "Toprak", BirthDate = new DateTime(1970, 1, 1) };
student1.Print();
teacher1.Print();

internal class Person
{
    public string? Name { get; init; }
    public string? Surname { get; init; }
    public DateTime? BirthDate { get; init; }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}, Surname: {Surname}, BirthDate: {BirthDate}");
    }
}