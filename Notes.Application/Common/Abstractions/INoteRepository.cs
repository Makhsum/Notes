using Notes.Domain.Models;

namespace Notes.Application.Common.Abstractions;

public interface INoteRepository:IRepository<Note>
{
    Task<IEnumerable<Note>> GetAll();
}