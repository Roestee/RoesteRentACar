using Microsoft.EntityFrameworkCore;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Persistence.Context;

namespace RoesteRentACar.Persistence.Repositories
{
    public class Repository<T>: IRepository<T> where T : class
    {
        private readonly RentACarDbContext _context;
        private DbSet<T> _dbSet;

        public Repository(RentACarDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<List<T>> GetAllAsync(CancellationToken c = default)
        {
            return await _dbSet.ToListAsync(c);
        }

        public async Task<T> GetByIdAsync(int id, CancellationToken c = default)
        {
            return await _dbSet.FindAsync(id, c);
        }

        public async Task AddAsync(T entity, CancellationToken c = default)
        {
            await _dbSet.AddAsync(entity, c);
            await _context.SaveChangesAsync(c);
        }

        public async Task UpdateAsync(T entity, CancellationToken c = default)
        {
            await Task.Run(() => _dbSet.Update(entity), c);
            await _context.SaveChangesAsync(c);
        }

        public async Task DeleteAsync(T entity, CancellationToken c = default)
        {
            await Task.Run(() => _dbSet.Remove(entity), c);
            await _context.SaveChangesAsync(c);
        }
    }
}
