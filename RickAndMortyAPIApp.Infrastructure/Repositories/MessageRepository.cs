using AutoMapper;
using ClassLibrary1.IRepositories;
using RickAndMortyAPIApp.Domain.Entities;

namespace RickAndMortyAPIApp.Infrastructure.Repositories;

public class MessageRepository  : BaseRepository<MessageEntity>, IMessageRepository
{
    public MessageRepository(AppDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}