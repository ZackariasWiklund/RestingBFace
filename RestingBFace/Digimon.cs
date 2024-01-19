using System.Text.Json.Serialization;


public class Digimon
{
    
    [JsonPropertyName("name")]
     public string name { get; set; }

    public List<DigimonType> types { get; set; }

    public List<DigimonAttribute> attributes { get; set; }

    
}