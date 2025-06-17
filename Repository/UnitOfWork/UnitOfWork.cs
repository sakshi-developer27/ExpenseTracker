using ExpenseTracker.Service.AuthService;

namespace ExpenseTracker.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IAuthService AuthService => throw new NotImplementedException();

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
