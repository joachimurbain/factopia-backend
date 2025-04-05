using factopia_backend.Domain.CustomEnums;
using factopia_backend.Domain.Models;

namespace factopia_backend.Api.DTOs;

public class ResourceDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Path { get; set; }
    public required FileType FileType { get; set; }
    public bool IsCorrect { get; set; }


    public int QuestionId { get; set; }
}
