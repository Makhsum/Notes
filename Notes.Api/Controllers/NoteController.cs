using Microsoft.AspNetCore.Mvc;
using Notes.Application.Common.abstractions;
using Notes.Application.Common.Abstractions;
using Notes.Domain.Models;

namespace Notes.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class NoteController:ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;
    
    
    public NoteController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(long id)
    {
        var note = await _unitOfWork.Notes.GetById(id);
        if (note != null)
        {
            return Ok(note);
            
        }
        return NotFound();
    }

    [HttpPost(Name = "CreateNote")]
    public async Task Create(Note note)
    {
        await _unitOfWork.Notes.Add(note);
        await _unitOfWork.CompleteAsync();
    }
[HttpDelete]
    public async Task<IActionResult> Delete(long id)
    {
        bool delete = await _unitOfWork.Notes.Remove(id);
        if (delete)
        {
            await _unitOfWork.CompleteAsync();
            return Ok();
        }

        return NotFound();
    } 
    [HttpPut]
    public async Task<IActionResult> Update(Note entity)
    {
      bool update = await _unitOfWork.Notes.Update(entity);
      if (update)
      {
          await _unitOfWork.CompleteAsync();
          return Ok();
      }

      return NotFound();

    }
[HttpGet]
    public async Task<IEnumerable<Note>> GetAll()
    {
        return await _unitOfWork.Notes.GetAll();
    }
}