using AutoMapper;
using ClassLibrary1.IRepositories;
using RickAndMortyAPIApp.Domain.Entities;

namespace RickAndMortyAPIApp.Infrastructure.Repositories;

public class LocationRepository : BaseRepository<LocationEntity>, ILocationRepository
{
    public LocationRepository(AppDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}