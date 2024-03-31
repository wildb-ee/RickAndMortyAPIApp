using AutoMapper;
using ClassLibrary1.IRepositories;
using RickAndMortyAPIApp.Domain.Entities;

namespace RickAndMortyAPIApp.Infrastructure.Repositories;

public class EpisodeRepository : BaseRepository<EpisodeEntity>, IEpisodeRepository
{
    public EpisodeRepository(AppDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}