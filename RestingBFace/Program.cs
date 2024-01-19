using RestSharp;
using System.Data;
using System.Text.Json;

RestClient client = new ("https://digi-api.com/api/v1/");

string digimonName = "aegiochusmon";
RestRequest request = new ($"digimon/{digimonName}");

RestResponse response = client.GetAsync(request).Result;

Digimon d = JsonSerializer.Deserialize<Digimon>(response.Content);

Console.WriteLine(d.name);

Console.WriteLine(d.types[0].type);

//Console.WriteLine(response.Content);

//(File.WriteAllText("digimon.json", response.Content);

Console.ReadLine();