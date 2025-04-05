using factopia_backend.Domain.CustomEnums;
using factopia_backend.Domain.Interfaces;

namespace factopia_backend.DAL.Repositories.Interfaces;

public interface IBaseRepository<T> where T : class, IEntity
{
    Task<T?> GetByIdAsync(int id, TrackingBehavior tracking = TrackingBehavior.AsNoTracking);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> AddAsync(T entity);
    Task RemoveAsync(T entity);
}
