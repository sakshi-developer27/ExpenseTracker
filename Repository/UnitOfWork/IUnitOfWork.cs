using ExpenseTracker.Models;
using ExpenseTracker.Repository.Generic;

namespace ExpenseTracker.Repository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<User> Users { get; }
        Task<int> CompleteAsync();
    }
}
