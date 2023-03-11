using Notes.Domain.Models;

namespace Notes.Application.Common.Abstractions;

public interface IRepository<TEntity> where TEntity:EntityBase
{
    Task<bool> Add(TEntity entity);
    Task<TEntity> GetById(long id);
    Task<bool> Remove(long id);
    Task<bool> Update(TEntity entity);
    
}