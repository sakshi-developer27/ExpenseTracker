using ExpenseTracker.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ExpenseTracker.Repository.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDBContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(ApplicationDBContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public async Task AddAsyn(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.CountAsync(predicate);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id) ??
            throw new KeyNotFoundException($"Entity of type {typeof(T).Name} with ID {id} not found.");
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entites)
        {
            _dbSet.RemoveRange(entites);
        }

        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
