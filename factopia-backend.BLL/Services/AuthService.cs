using Azure.Identity;
using factopia_backend.BLL.CustomExceptions;
using factopia_backend.BLL.Services.Interfaces;
using factopia_backend.DAL.Repositories.Interfaces;
using factopia_backend.Domain.Models;
using Isopoh.Cryptography.Argon2;

namespace factopia_backend.BLL.Services;

public class AuthService : BaseService<User>, IAuthService
{
    private readonly IAuthRepository _authRepository;
    public AuthService(IAuthRepository repository) : base(repository)
    {
        _authRepository = repository;
    }
    // pas besoin ici ?
    // public AuthService(IAuthRepository repository) : base(repository) { }
    public async Task<User> LoginAsync(string email, string password)
    {
        string? pwdFromDB = await _authRepository.GetPasswordHashByEmailAsync(email);
        if (pwdFromDB is null || !Argon2.Verify(pwdFromDB, password)) throw new InvalidCredentialsException();

        return await _authRepository.LoginAsync(email);
    }

    public async Task<User> RegisterAsync(User user)
    {
        bool emailExist = await _authRepository.EmailExist(user.Email);
        if (emailExist) throw new EmailAlreadyExistException();

        user.Password = Argon2.Hash(user.Password);

        return await _authRepository.RegisterAsync(user);
    }
}
