using ExpenseTracker.Models.Core;

namespace ExpenseTracker.Models.Category
{
    public class Category : Auditable
    {
        public Guid CategoryId { get; set; }
        public required string CategoryName { get; set; }
        public required string Description { get; set; }
    }
}
