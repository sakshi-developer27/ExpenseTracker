using ExpenseTracker.Models.User;
using ExpenseTracker.Repository.Generic;

namespace ExpenseTracker.Repository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<UserMaster> Users { get; }
        Task<int> CompleteAsync();
    }
}
