using ExpenseTracker.Models;
using ExpenseTracker.Repository.UnitOfWork;
using ExpenseTracker.ViewModel;

namespace ExpenseTracker.Service.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AuthService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<User?> LoginAsync(string email, string password)
        {
            var user = (await _unitOfWork.Users.GetAll())
                .FirstOrDefault(u => u.Email == email && u.Password == password);
            return user;
        }
        public async Task<bool> RegisterAsync(UserViewModel userViewModel)
        {
            var exists = await _unitOfWork.Users.AnyAsync(u => u.Email == userViewModel.Email);
            if (exists)
            {
                return false;
            }
            var user = new User
            {
                Email = userViewModel.Email,
                Password = userViewModel.Password
            };
            await _unitOfWork.Users.AddAsync(user);
            await _unitOfWork.CompleteAsync();

            return true;
        }
    }
}
