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

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return _dbSet.ToList();
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

    public async Task RemoveAsync(T entity)
    {
        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
    }
}
