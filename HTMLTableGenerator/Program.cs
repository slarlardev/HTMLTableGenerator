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
string tabloBasla = "";
// Tablo başlıklar
string tabloBasliklar = "";
// Tablo gövde
string tabloGovde = "";
// Tablo kapat
string tabloKapat = "";

string tablo = tabloBasla + tabloBasliklar + tabloGovde + tabloKapat;
File.WriteAllText("output.html", tablo);



