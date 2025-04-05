using factopia_backend.Domain.Interfaces;

namespace factopia_backend.Domain.Models;

public class Answer : IEntity
{
    public int Id { get; set; }
    public string Content { get; set; }
    public bool IsCorrect { get; set; }
    public int QuestionId { get; set; }
    public Question Question { get; set; }
}
