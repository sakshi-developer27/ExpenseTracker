using ExpenseTracker.Models.Core;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models.User
{
    public class UserMaster : Auditable
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string? Name { get; set; }
        [Required]
        [StringLength(250)]
        public string? Email { get; set; }
        [Required]
        [StringLength(250)]
        public string? Password { get; set; }
        public bool IsActive { get; set; }
    }
}
