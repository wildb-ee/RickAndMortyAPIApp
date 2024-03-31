namespace RickAndMortyAPIApp.Domain.SeedWork;

public interface IUnitOfWork {
    IRepository<TEntity> GetRepository<TEntity>() where TEntity : Entity, IAggregateRoot;
    Task SaveChangesAsync();
}