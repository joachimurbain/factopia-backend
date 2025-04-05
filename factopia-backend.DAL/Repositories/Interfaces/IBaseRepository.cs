using factopia_backend.Domain.Interfaces;

namespace factopia_backend.DAL.Repositories.Interfaces;

public interface IBaseRepository<T> where T : class, IEntity
{
    Task<T?> GetByIdAsync(int id, bool isForDelete = false);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> AddAsync(T entity);
    Task RemoveAsync(T entity);
}
