using factopia_backend.Domain.Models;

namespace factopia_backend.Api.DTOs;

public class QuestionDTO
{

    public int Id { get; set; }
    public string Content { get; set; }
    public GameType GameType { get; set; }
    public List<ResourceDTO> Resources { get; set; } = [];
    public List<AnswerDTO> Answers { get; set; }

}
