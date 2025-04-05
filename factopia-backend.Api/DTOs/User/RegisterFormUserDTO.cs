using factopia_backend.Domain.CustomEnums;

namespace factopia_backend.Api.DTOs.User;

public class RegisterFormUserDTO
{
    public int BirthYear { get; set; }
    public string Email { get; set; }
    public string Pseudo { get; set; }
    public GenderEnum Gender { get; set; }
    public string Password { get; set; }
}
