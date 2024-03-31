using AutoMapper;
using ClassLibrary1.IRepositories;
using RickAndMortyAPIApp.Domain.Entities;
using RickAndMortyAPIApp.Domain.SeedWork;

namespace RickAndMortyAPIApp.Infrastructure.Repositories;

public class CharacterRepository : BaseRepository<CharacterEntity>, ICharacterRepository
{
    public CharacterRepository(AppDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}