using Notes.Application.Common.Abstractions;
using Notes.Infrastructure.Persistence;
using Notes.Infrastructure.Persistence.Repository;

namespace Notes.Infrastructure.Configurations;

public class UnitOfWork:IUnitOfWork,IDisposable
{
    private readonly ApplicationDbContext _context;
    public INoteRepository Notes { get; }

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        Notes = new NoteRepository(_context);
    }
    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}