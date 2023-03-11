using Microsoft.EntityFrameworkCore;
using Notes.Domain.Models;

namespace Notes.Infrastructure.Persistence;

public class ApplicationDbContext:DbContext
{
    public  DbSet<Note> Notes { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base (options)
    {
        // Database.EnsureDeleted();
        Database.EnsureCreated();
    }
}