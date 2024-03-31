namespace RickAndMortyAPIApp.Domain.SeedWork;

public class NamedAPIResource
{
    public string?  Name { get; set; }
    public string? Url { get; set; }

    public NamedAPIResource(string? name, string? url )
    {
        Name = name;
        Url = url;

    }
    
}