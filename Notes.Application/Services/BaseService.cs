using Notes.Application.Common.abstractions;
using Notes.Domain.Models;

namespace Notes.Application.Services;

public abstract class BaseService<TEntity>:IBaseService<TEntity> where TEntity:EntityBase
{
    public virtual TEntity Get(long id)
    {
        throw new NotImplementedException();
    }

    public virtual void Create(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public virtual IEnumerable<TEntity> GetAll()
    {
        throw new NotImplementedException();
    }

    public virtual void Update(TEntity entity, long id)
    {
        throw new NotImplementedException();
    }

    public virtual void Delete(long id)
    {
        throw new NotImplementedException();
    }
}