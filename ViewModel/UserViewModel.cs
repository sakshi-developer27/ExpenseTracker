using ExpenseTracker.Constants;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.ViewModel
{
    public class UserViewModel
    {
        [Required(ErrorMessage = ResponseMessage.NameRequired)]
        [MaxLength(100, ErrorMessage = (ResponseMessage.NameTooLong))]
        public string? Name { get; set; }

        [Required(ErrorMessage = ResponseMessage.EmailRequired)]
        [EmailAddress(ErrorMessage = ResponseMessage.InvalidEmailFormat)]
        [MaxLength(100, ErrorMessage = ResponseMessage.EmailTooLong)]
        public string? Email { get; set; }

        [Required(ErrorMessage = ResponseMessage.PasswordRequired)]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$",
            ErrorMessage = (ResponseMessage.InvalidPasswordFormat))]
        public string? Password { get; set; }
    }
}
