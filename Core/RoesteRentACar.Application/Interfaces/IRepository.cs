namespace RoesteRentACar.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync(CancellationToken c);
        Task<T> GetByIdAsync(int id, CancellationToken c);

        Task AddAsync(T entity, CancellationToken c);
        Task UpdateAsync(T entity, CancellationToken c);
        Task DeleteAsync(T entity, CancellationToken c);
    }
}
