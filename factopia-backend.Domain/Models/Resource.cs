using factopia_backend.Domain.CustomEnums;
using factopia_backend.Domain.Interfaces;

namespace factopia_backend.Domain.Models;

public class Resource : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Path { get; set; }
    public required FileType FileType { get; set; }
    public bool IsCorrect { get; set; }


    public int QuestionId { get; set; }
    public Question question { get; set; }

}
