using ExpenseTracker.Repository.Generic;
using ExpenseTracker.Service.AuthService;

namespace ExpenseTracker.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<T> Repository<T>() where T : class;
        IAuthService AuthService { get; }
        Task<int> SaveChangesAsync();
    }
}
