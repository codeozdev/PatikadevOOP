using Week07_02;

List<Singers> singersList =
[
    new Singers
    {
        SingerName = "Ajda Pekkan",
        SingerType = "Pop",
        ReleaseYear = 1968,
        AlbumSales = 20_000_000
    },
    new Singers
    {
        SingerName = "Sezen Aksu",
        SingerType = "Türk Halk Müziği / Pop",
        ReleaseYear = 1971,
        AlbumSales = 10_000_000
    },
    new Singers
    {
        SingerName = "Funda Arar",
        SingerType = "Pop",
        ReleaseYear = 1999,
        AlbumSales = 3_000_000
    },
    new Singers
    {
        SingerName = "Sertab Erener",
        SingerType = "Pop",
        ReleaseYear = 1994,
        AlbumSales = 5_000_000
    },
    new Singers
    {
        SingerName = "Sıla",
        SingerType = "Pop",
        ReleaseYear = 2009,
        AlbumSales = 3_000_000
    },
    new Singers
    {
        SingerName = "Serdar Ortaç",
        SingerType = "Pop",
        ReleaseYear = 1994,
        AlbumSales = 10_000_000
    },
    new Singers
    {
        SingerName = "Tarkan",
        SingerType = "Pop",
        ReleaseYear = 1992,
        AlbumSales = 40_000_000
    },
    new Singers
    {
        SingerName = "Hande Yener",
        SingerType = "Pop",
        ReleaseYear = 1999,
        AlbumSales = 7_000_000
    },
    new Singers
    {
        SingerName = "Hadise",
        SingerType = "Pop",
        ReleaseYear = 2005,
        AlbumSales = 5_000_000
    },
    new Singers
    {
        SingerName = "Gülben Ergen",
        SingerType = "Pop / Türk Halk Müziği",
        ReleaseYear = 1997,
        AlbumSales = 10_000_000
    },
    new Singers
    {
        SingerName = "Neşet Ertaş",
        SingerType = "Türk Halk Müziği / Türk Sanat Müziği",
        ReleaseYear = 1960,
        AlbumSales = 2_000_000
    },
];


// S ile başlayan şarkıcıları listeleme
var s = singersList.Where(s => s.SingerName!.StartsWith($"S"));

foreach (var singer in s)
{
    Console.WriteLine(singer.SingerName);
}

// Albüm satışları 10 milyon'un üzerinde olan şarkıcıları listeleme
var albumSales = singersList.Where(x => x.AlbumSales > 10_000_000).OrderByDescending(x => x.AlbumSales);
foreach (var album in albumSales)
{
    Console.WriteLine($"Sanatcı: {album.SingerName}, Albüm Satışı: {album.AlbumSales}");
}

// 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. ( Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.
var popSingers = singersList.Where(x => x is { ReleaseYear: < 2000, SingerType: "Pop" }).OrderBy(x => x.SingerName);
foreach (var pop in popSingers)
{
    Console.WriteLine($"Sanatcı: {pop.SingerName}, Çıkış Yılı: {pop.ReleaseYear}");
}

// En çok albüm satan şarkıcı
var mostAlbumSales = singersList.OrderByDescending(x => x.AlbumSales).First();
Console.WriteLine($"En çok albüm satan şarkıcı: {mostAlbumSales.SingerName}");

// En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı
var newestSinger = singersList.OrderByDescending(x => x.ReleaseYear).First();
var oldestSinger = singersList.OrderBy(x => x.ReleaseYear).First();
Console.WriteLine($"En yeni çıkış yapan şarkıcı: {newestSinger.SingerName}, Çıkış Yılı: {newestSinger.ReleaseYear}");
Console.WriteLine($"En eski çıkış yapan şarkıcı: {oldestSinger.SingerName}, Çıkış Yılı: {oldestSinger.ReleaseYear}");