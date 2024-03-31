﻿using System;
using System.Linq.Expressions;

namespace RickAndMortyAPIApp.Domain.SeedWork;

public interface IRepository<TEntity>
    where TEntity : Entity, IAggregateRoot
{
    Task<TEntity?> GetAsync(Guid id, string[]? includeProperties = null);
    Task<TEntity?> FirstOrDefault(Expression<Func<TEntity, bool>>? filter = null, string[]? includeProperties = null);
    Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>>? filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, string[]? includeProperties = null);
    Task<bool> Any(Expression<Func<TEntity, bool>> filter);
    Task<int> Count(Expression<Func<TEntity, bool>>? filter = null);
    Task Delete(Guid id);
    Task DeleteRange(Guid[] ids);
    Task AddAsync(TEntity entity);
    Task AddRangeAsync(TEntity[] entity);
    void Update(TEntity entityToUpdate);
}