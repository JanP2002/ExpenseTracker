using ExpenseTracker.Models;
using ExpenseTracker.Dtos;

namespace ExpenseTracker.Services
{
    public interface IExpenseService
    {
        IEnumerable<Expense> GetExpenses();
        Expense? GetExpense(int id);
        void AddExpense(CreateExpenseDto expense);
        void UpdateExpense(Expense expense);
        void DeleteExpense(int id);
    }
}
