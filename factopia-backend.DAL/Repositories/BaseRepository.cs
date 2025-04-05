using factopia_backend.DAL.Database;
using factopia_backend.DAL.Repositories.Interfaces;
using factopia_backend.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace factopia_backend.DAL.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : class, IEntity
{
    protected readonly DataContext _context;
    protected readonly DbSet<T> _dbSet;

    public BaseRepository(DataContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }
    public async Task<T> AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public Task<IEnumerable<T>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<T?> GetByIdAsync(int id, bool isForDelete = false)
    {
        IQueryable<T> query = _dbSet;

        if (!isForDelete)
        {
            query = query
                    .AsNoTracking();
        }

        return await query.FirstOrDefaultAsync(p => p.Id == id);
    }

    public Task<T> RemoveAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
