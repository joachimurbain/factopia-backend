using factopia_backend.Domain.Models;

namespace factopia_backend.BLL.Services.Interfaces;

public interface IAuthService : IBaseService<User>
{
    Task<User> RegisterAsync(User user);
    Task<User> LoginAsync(string email, string password);
}
