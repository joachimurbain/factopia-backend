using factopia_backend.BLL.CustomExceptions;
using factopia_backend.BLL.Services.Interfaces;
using factopia_backend.DAL.Repositories.Interfaces;
using factopia_backend.Domain.CustomEnums;
using factopia_backend.Domain.Interfaces;

namespace factopia_backend.BLL.Services;

public class BaseService<T> : IBaseService<T> where T : class, IEntity
{
    protected readonly IBaseRepository<T> _repository;

    public BaseService(IBaseRepository<T> repository)
    {
        _repository = repository;
    }

    public async Task<T> AddAsync(T entity)
    {
        return await _repository.AddAsync(entity);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<T?> GetByIdAsync(int id, TrackingBehavior tracking = TrackingBehavior.AsNoTracking)
    {
        T? entity = await _repository.GetByIdAsync(id);
        if (entity is null) throw new EntityNotFoundException();

        return entity;
    }

    public async Task RemoveAsync(int id)
    {
        T? entity = await _repository.GetByIdAsync(id);
        if (entity is null) throw new EntityNotFoundException();

        await _repository.RemoveAsync(entity);
    }
}
