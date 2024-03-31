using AutoMapper;
using ClassLibrary1.IRepositories;
using RickAndMortyAPIApp.Domain.Entities;

namespace RickAndMortyAPIApp.Infrastructure.Repositories;

public class UserRepository : BaseRepository<UserEntity>, IUserRepository
{
    public UserRepository(AppDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}