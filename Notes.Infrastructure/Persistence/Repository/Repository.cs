using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Notes.Application.Common.Abstractions;
using Notes.Domain.Models;

namespace Notes.Infrastructure.Persistence.Repository;

public abstract class Repository<TEntity>:IRepository<TEntity> where TEntity:EntityBase
{
    protected ApplicationDbContext _context;
    protected DbSet<TEntity> _dbSet;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }
    public virtual  Task<bool> Add(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public virtual  Task<TEntity> GetById(long id)
    {
        throw new NotImplementedException();
    }

    public virtual  Task<bool> Remove(long id)
    {
        throw new NotImplementedException();
    }

    public virtual  Task<bool> Update(TEntity entity)
    {
        throw new NotImplementedException();
    }
}