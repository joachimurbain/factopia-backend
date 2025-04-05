using factopia_backend.Domain.Interfaces;

namespace factopia_backend.BLL.Services.Interfaces;

public interface IBaseService<T> where T : class, IEntity
{
    Task<T?> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> AddAsync(T entity);
    Task RemoveAsync(int id);
}
