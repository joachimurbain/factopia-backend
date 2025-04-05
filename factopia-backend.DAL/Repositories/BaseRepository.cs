using factopia_backend.DAL.Database;
using factopia_backend.DAL.Repositories.Interfaces;
using factopia_backend.Domain.CustomEnums;
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
    public virtual async Task<T> AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync()
    {
        return _dbSet.ToList();
    }

    public virtual async Task<T?> GetByIdAsync(int id, TrackingBehavior tracking = TrackingBehavior.AsNoTracking)
    {
        IQueryable<T> query = _dbSet;

        if (tracking == TrackingBehavior.AsNoTracking)
        {
            query = query
                    .AsNoTracking();
        }

        return await query.FirstOrDefaultAsync(p => p.Id == id);
    }

    public virtual async Task RemoveAsync(T entity)
    {
        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
    }
}
