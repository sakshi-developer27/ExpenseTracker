using ExpenseTracker.Models.User;
using ExpenseTracker.ViewModel;

namespace ExpenseTracker.Service.AuthService
{
    public interface IAuthService
    {
        Task<bool> RegisterAsync(UserViewModel userViewModel);
        Task<UserMaster?> LoginAsync(string email, string password);
    }
}
