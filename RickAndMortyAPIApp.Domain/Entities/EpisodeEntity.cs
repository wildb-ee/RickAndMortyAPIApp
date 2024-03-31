using RickAndMortyAPIApp.Domain.SeedWork;

namespace RickAndMortyAPIApp.Domain.Entities;

public class EpisodeEntity : Entity, IAggregateRoot
{
    public string? Name { get; set; }
    public string? AirDate { get; set; }
    public string? Episode { get; set; }
    public List<string>? Characters { get; set; }
    public string? Url { get; set; }
    public string? Created { get; set; }
    
    public long SystemId { get; set; }
}