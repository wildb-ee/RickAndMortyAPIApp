using RickAndMortyAPIApp.Domain.SeedWork;

namespace RickAndMortyAPIApp.Domain.Entities;

public class LocationEntity : Entity, IAggregateRoot
{
    public string? Name { get; set; }
    public string? Type { get; set; }
    public string? Dimension { get; set; }
    public List<string>? Residents { get; set; }
    public string? Url { get; set; }
    public string? Created { get; set; }
    public long SystemId { get; set; }
}