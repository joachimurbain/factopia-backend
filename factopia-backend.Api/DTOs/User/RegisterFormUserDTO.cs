using factopia_backend.Domain.CustomEnums;
using System.ComponentModel.DataAnnotations;

namespace factopia_backend.Api.DTOs.User;

public class RegisterFormUserDTO
{
    [Range(1900,2015), Required]
    public int BirthYear { get; set; }
    [EmailAddress, MaxLength(100), Required]
    public string Email { get; set; }
    [MinLength(2), MaxLength(50)]
    public string Pseudo { get; set; }
    [Required]
    public GenderEnum Gender { get; set; }
    [Required, RegularExpression("^(?=.*[A-Z])(?=.*[!@#$%^&*()_\\-+=\\[{\\]};:'\",<.>/?\\\\|`~]).{8,}$\r\n")]
    public string Password { get; set; }
}
