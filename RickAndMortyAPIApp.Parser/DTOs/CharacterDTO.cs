namespace RickAndMortyAPIApp.Parser.DTOs;

public class CharacterDTO
{
    public int id { get; set; }
    public string name { get; set; }
    public string status { get; set; }
    public string species { get; set; }
    public string type { get; set; }
    public string gender { get; set; }
    public NamedAPIResourceDTO location { get; set; }
    public NamedAPIResourceDTO origin { get; set; }
    public string image { get; set; }
    public List<string> episode { get; set; }
    public string url { get; set; }
    public string created { get; set; } 
}