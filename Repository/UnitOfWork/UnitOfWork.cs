using ExpenseTracker.Data;
using ExpenseTracker.Repository.Generic;
using ExpenseTracker.Service.AuthService;

namespace ExpenseTracker.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _context;
        private readonly IAuthService _authService;
        private readonly IGenericRepository<T> _genericRepository;

        public UnitOfWork(ApplicationDBContext context, IAuthService authService, IGenericRepository genericRepository)
        {
            _context = context;
            _authService = authService;
            _genericRepository = genericRepository;
        }
        public IAuthService AuthService => _authService;
        public IGenericRepository GenericRepository => _genericRepository;

        public IGenericRepository<T> Repository<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
