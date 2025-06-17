using ExpenseTracker.Service.AuthService;

namespace ExpenseTracker.Repository.UnitOfWork
{
    public interface IUnitOfWork
    {
        IAuthService AuthService { get; }
        Task<int> SaveChangesAsync();
    }
}
