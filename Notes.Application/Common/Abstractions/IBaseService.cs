using Notes.Domain.Models;

namespace Notes.Application.Common.abstractions;

public interface IBaseService<TEntity> where TEntity:EntityBase
{
    TEntity Get(long id);
    void Create(TEntity entity);
    IEnumerable<TEntity> GetAll();
    void Update(TEntity entity, long id);
    void Delete(long id);
}