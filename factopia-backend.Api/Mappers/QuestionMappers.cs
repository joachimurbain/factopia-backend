using System.Runtime.CompilerServices;
using factopia_backend.Api.DTOs;
using factopia_backend.Domain.Models;

namespace factopia_backend.Api.Mappers;

public static class QuestionMappers
{
    public static QuestionDTO toDetailsDTO(this Question entity)
    {
        return new QuestionDTO
        {
            Id = entity.Id,
            Content = entity.Content,
            Answers = entity.Answers.Select(a => a.toDetailsDTO()).ToList(),
            Files = entity.Resources.Select(f=>f.toDetailsDTO()).ToList(),
            GameType = entity.GameType,

        };
    }
}
