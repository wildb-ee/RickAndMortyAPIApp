using RickAndMortyAPIApp.Domain.SeedWork;

namespace RickAndMortyAPIApp.Domain.Entities;

public class UserEntity :Entity, IAggregateRoot
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}