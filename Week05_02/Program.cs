List<string> davetliler =
    ["Bülent Ersoy", "Ajda Pekkan", "Ebru Gündeş", "Hadise", "Hande Yener", "Tarkan", "Funda Arar", "Demet Akalın"];

var index = 0;
foreach (var davetli in davetliler)
{
    Console.WriteLine($"{index + 1} - {davetli}");
    index++;
}