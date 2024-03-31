using RickAndMortyAPIApp.Domain.SeedWork;

namespace RickAndMortyAPIApp.Domain.Entities;

public class MessageEntity : Entity, IAggregateRoot
{
    public string Message { get; set; }
}