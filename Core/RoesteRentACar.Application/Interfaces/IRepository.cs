using System.Linq.Expressions;

namespace RoesteRentACar.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync(CancellationToken c = default);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter, CancellationToken c = default);
        Task<T> GetByIdAsync(int id, CancellationToken c = default);
        Task AddAsync(T entity, CancellationToken c = default);
        Task UpdateAsync(T entity, CancellationToken c = default);
        Task DeleteAsync(T entity, CancellationToken c = default);
        IQueryable<T> GetAllQueryable();
    }
}
