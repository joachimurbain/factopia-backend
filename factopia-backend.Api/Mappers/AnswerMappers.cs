using factopia_backend.Api.DTOs;
using factopia_backend.Domain.Models;

namespace factopia_backend.Api.Mappers;

public static class AnswerMappers
{
    public static AnswerDTO toDetailsDTO(this Answer entity)
    {
        return new AnswerDTO
        {
            Id = entity.Id,
            Content = entity.Content,
            IsCorrect = entity.IsCorrect,
            QuestionId = entity.QuestionId
        };
    }
}
