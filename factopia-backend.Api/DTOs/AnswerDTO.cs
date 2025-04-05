using factopia_backend.Domain.Models;

namespace factopia_backend.Api.DTOs;

public class AnswerDTO
{
    public int Id { get; set; }
    public string Content { get; set; }
    public bool IsCorrect { get; set; }
    public int QuestionId { get; set; }
}
