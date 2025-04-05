using factopia_backend.Api.DTOs.User;
using factopia_backend.Domain.Models;

namespace factopia_backend.Api.Mappers;

public static class UserMapper
{
    public static User ToRegisterEntity(this RegisterFormUserDTO dto)
    {
        return new()
        {
            BirthYear = dto.BirthYear,
            Email = dto.Email,
            Gender = dto.Gender,
            Password = dto.Password,
            Pseudo = dto.Pseudo,
        };
    }
}
