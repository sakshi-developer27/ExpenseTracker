namespace ExpenseTracker.Models
{
    public class Category : AuditableEntity
    {
        public Guid TransactionId { get; set; }
        public decimal Amount { get; set; }
    }
}
