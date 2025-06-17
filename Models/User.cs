using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class User : AuditableEntity
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
