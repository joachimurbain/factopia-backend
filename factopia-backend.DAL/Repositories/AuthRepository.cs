using factopia_backend.DAL.Database;
using factopia_backend.DAL.Repositories.Interfaces;
using factopia_backend.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace factopia_backend.DAL.Repositories;

public class AuthRepository : BaseRepository<User>, IAuthRepository
{
    public AuthRepository(DataContext dataContext) : base(dataContext) { }

    public async Task<bool> EmailExist(string email)
    {
        return await _dbSet.AnyAsync(u => u.Email == email);
    }

    public async Task<string?> GetPasswordHashByEmailAsync(string email)
    {
        return await _dbSet
            .Where(u => u.Email == email)
            .Select(u => u.Password)
            .FirstOrDefaultAsync();
    }

    public async Task<User> LoginAsync(string email)
    {
        return await _dbSet
            .Where(u => u.Email == email)
            .FirstAsync();
    }

    public async Task<User> RegisterAsync(User user)
    {
        await _dbSet.AddAsync(user);
        await _context.SaveChangesAsync();

        return user;
    }
}
