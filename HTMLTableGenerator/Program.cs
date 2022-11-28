using HTMLTableGenerator;
using System.Text.Json;

string moviesText = File.ReadAllText("movies.json");
//Console.WriteLine(moviesText);

var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
List<Movie> movies = JsonSerializer.Deserialize<List<Movie>>(moviesText, options);

//foreach (var m in movies)
//{
//    Console.WriteLine(m.Title);
//}

// Tablo başla
string tabloBasla = "<table>";

// Tablo başlıklar
string tabloBasliklar = "<thead><tr><td>id</td><td>title</td><td>rating</td><td>genre</td><td>duration </td></tr></thead>";

// Tablo gövde

string tabloGovde = "<tbody>";

foreach (var m in movies)
{
     tabloGovde += $"<tr>" +
        $"<td> {m.Id} </td >" +
        $"<td> {m.Title}</td >" +
        $"<td> {m.Rating}</td >" +
        $"<td> {m.Genre} </td >" +
        $"<td> {m.Duration} </td >" +
        $"</tr> ";
}

tabloGovde += "</tbody>";

// Tablo kapat
string tabloKapat = "</table>";

string tablo = tabloBasla + tabloBasliklar + tabloGovde + tabloKapat;
File.WriteAllText("output.html", tablo);



