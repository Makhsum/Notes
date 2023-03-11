namespace Notes.Application.Common.Abstractions;

public interface IUnitOfWork
{
     INoteRepository Notes { get; }
     Task CompleteAsync();
}