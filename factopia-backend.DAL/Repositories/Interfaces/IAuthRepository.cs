using factopia_backend.Domain.Models;

namespace factopia_backend.DAL.Repositories.Interfaces;

public interface IAuthRepository : IBaseRepository<User>
{
    Task<User> RegisterAsync(User user);
    Task<User> LoginAsync(string email);
    Task<bool> EmailExist(string email);
    Task<string?> GetPasswordHashByEmailAsync(string email);
}
