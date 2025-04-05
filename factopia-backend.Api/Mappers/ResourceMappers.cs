using factopia_backend.Api.DTOs;
using factopia_backend.Domain.Models;

namespace factopia_backend.Api.Mappers;

public static class ResourceMappers
{
    public static ResourceDTO toDetailsDTO(this Resource entity)
    {
        return new ResourceDTO
        {
            Id = entity.Id,
            FileType = entity.FileType,
            Name = entity.Name,
            Path = entity.Path,
            IsCorrect = entity.IsCorrect,
            QuestionId = entity.QuestionId
        };
    }
}
