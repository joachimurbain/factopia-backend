using factopia_backend.Domain.CustomEnums;
using factopia_backend.Domain.Interfaces;

namespace factopia_backend.Domain.Models;

public class User : IEntity
{
    public int Id { get; set; }
    public int BirthYear { get; set; }
    public string Email { get; set; }
    public string Pseudo { get; set; }
    public GenderEnum Gender { get; set; }
    public string Password { get; set; }
    public RoleEnum Role { get; set; }
    public int Score { get; set; }
    public List<UserQuestion> UserQuestion { get; set; }
}
