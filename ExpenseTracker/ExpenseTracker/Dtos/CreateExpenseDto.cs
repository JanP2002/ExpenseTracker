namespace ExpenseTracker.Dtos
{
    public class CreateExpenseDto
    {
        public required decimal Value { get; set; }

        public required string Description { get; set; }
    }
}
