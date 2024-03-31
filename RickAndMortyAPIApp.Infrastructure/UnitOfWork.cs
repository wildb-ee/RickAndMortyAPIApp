using Microsoft.Extensions.DependencyInjection;
using RickAndMortyAPIApp.Domain.SeedWork;

namespace RickAndMortyAPIApp.Infrastructure;

public class UnitOfWork : IUnitOfWork {
    private readonly AppDbContext _context;
    private readonly IServiceProvider _serviceProvider;

    public UnitOfWork(AppDbContext context, IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        _context = context;
    }

    public IRepository<TDomain> GetRepository<TDomain>()
        where TDomain : Entity, IAggregateRoot
    {
        return (_serviceProvider.GetRequiredService(typeof(IRepository<TDomain>)) as IRepository<TDomain>)!;
    }

    public Task SaveChangesAsync()
    {
        Console.WriteLine("SAVED");
        return _context.SaveChangesAsync();
    }
}