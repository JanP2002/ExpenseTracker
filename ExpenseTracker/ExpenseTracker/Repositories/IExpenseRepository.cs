using ExpenseTracker.Models;

namespace ExpenseTracker.Repositories
{
    public interface IExpenseRepository
    {
        IEnumerable<Expense> GetExpenses();
        Expense? GetExpense(int id);
        void AddExpense(Expense expense);
        void UpdateExpense(Expense expense);
        void DeleteExpense(int id);
    }
}
