using ExpenseTracker.Models;
using ExpenseTracker.ViewModel;

namespace ExpenseTracker.Service.AuthService
{
    public interface IAuthService
    {
        Task<bool> RegisterAsync(UserViewModel userViewModel);
        Task<User?> LoginAsync(string email, string password);
    }
}
