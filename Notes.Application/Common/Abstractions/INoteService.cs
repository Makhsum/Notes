using Notes.Domain.Models;

namespace Notes.Application.Common.abstractions;

public interface INoteService
{
    Note Get(long id);
    void Create(Note entity);
    void Update(Note entity, long id);
    void Delete(long id);
    IEnumerable<Note> GetAll();
}