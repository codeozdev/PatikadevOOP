using Week07_04;

List<Author> authorList =
[
    new() { AuthorId = 1, Name = "Orhan Pamuk" },
    new() { AuthorId = 2, Name = "Elif Şafak" },
    new() { AuthorId = 3, Name = "Ahmet Ümit" }
];

List<Book> bookList =
[
    new() { BookId = 1, Title = "Benim Adım Kırmızı", AuthorId = 1 },
    new() { BookId = 2, Title = "İstanbul Hatırası", AuthorId = 3 },
    new() { BookId = 3, Title = "Aşk", AuthorId = 2 },
    new() { BookId = 4, Title = "Beyaz Kale", AuthorId = 1 }
];


var authorBookList = authorList.Join(
    bookList,
    author => author.AuthorId,
    book => book.AuthorId,
    (author, book) => new { author.Name, book.Title }
);

foreach (var item in authorBookList)
{
    Console.WriteLine($"Yazar: {item.Name} - Kitaplar: {item.Title}");
}