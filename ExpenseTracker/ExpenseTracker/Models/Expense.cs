using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public required decimal Value { get; set; }

        public required string? Description { get; set; }

    }
}
