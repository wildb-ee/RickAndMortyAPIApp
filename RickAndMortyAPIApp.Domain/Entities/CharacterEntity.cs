using RickAndMortyAPIApp.Domain.SeedWork;

namespace RickAndMortyAPIApp.Domain.Entities;

public class CharacterEntity : Entity, IAggregateRoot
{
    public string? Name { get; set; }
    public string? Status { get; set; }
    public string? Species { get; set; }
    public string? Type { get; set; }
    public string? Gender { get; set; }
    public NamedAPIResource? Location { get; set; }
    public NamedAPIResource? Origin { get; set; }
    public string? Image { get; set; }
    public List<string>? Episode { get; set; }
    public string? Url { get; set; }
    public string? Created { get; set; }
    
    public long SystemId { get; set; }
    
}