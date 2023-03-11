using Microsoft.EntityFrameworkCore;
using Notes.Application.Common.Abstractions;
using Notes.Domain;
using Notes.Domain.Models;

namespace Notes.Infrastructure.Persistence.Repository;

public class NoteRepository:Repository<Note>,INoteRepository
{


    public NoteRepository(ApplicationDbContext context):base(context)
    {
        
    }
    public override async Task<bool> Add(Note entity)
    {
        try
        {
           await _dbSet.AddAsync(entity);
           return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public override async Task<Note> GetById(long id)
    {
        try
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }
        catch (Exception e)
        {
            return new Note();
        }
    }

    public override async Task<bool> Remove(long id)
    {
        try
        {
            var existingnote = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
            if (existingnote!=null)
            {
                _dbSet.Remove(existingnote);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public override async Task<bool> Update(Note entity)
    {
        try
        {
            var existingnote = await _dbSet.FirstOrDefaultAsync(n => n.Id == entity.Id);
            if (existingnote == null)
                return false;
            existingnote.Body = entity.Body;
            existingnote.CreatedDate = entity.CreatedDate;
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public async Task<IEnumerable<Note>> GetAll()
    {
        try
        {
            return await _dbSet.ToListAsync();
        }
        catch (Exception e)
        {
            return new List<Note>();
        }
    }
}