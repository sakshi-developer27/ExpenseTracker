namespace ExpenseTracker.Repository.Generic
{
    public interface IGenericRepository
    {
        Task<int> SaveChangesAsync();
    }
}
