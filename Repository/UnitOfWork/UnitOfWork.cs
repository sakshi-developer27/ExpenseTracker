using ExpenseTracker.Data;
using ExpenseTracker.Models.User;
using ExpenseTracker.Repository.Generic;

namespace ExpenseTracker.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _context;
        public IGenericRepository<UserMaster> Users { get; private set; }

        public UnitOfWork(ApplicationDBContext context)
        {
            _context = context;
            Users = new GenericRepository<UserMaster>(_context);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
