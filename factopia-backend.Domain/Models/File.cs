using factopia_backend.Domain.CustomEnums;
using factopia_backend.Domain.Interfaces;

namespace factopia_backend.Domain.Models;

public class File : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public required string Path { get; set; }
    public FileType FileType { get; set; }
    public bool IsCorrect { get; set; }


    public int QuestionId { get; set; }
    public required Question question { get; set; }

}
