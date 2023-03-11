namespace Notes.Domain.Models;

public class Note:EntityBase
{
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public string Body { get; set; }
}