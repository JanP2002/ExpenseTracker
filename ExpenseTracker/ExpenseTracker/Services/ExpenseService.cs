using ExpenseTracker.Dtos;
using ExpenseTracker.Models;
using ExpenseTracker.Repositories;

namespace ExpenseTracker.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository _expenseRepository;

        public ExpenseService(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }
        public void AddExpense(CreateExpenseDto expense)
        {
            var expenseToAdd = new Expense
            {
                Value = expense.Value,
                Description = expense.Description,
            };

            _expenseRepository.AddExpense(expenseToAdd);
        }

        public void DeleteExpense(int id)
        {
            _expenseRepository.DeleteExpense(id);
        }

        public Expense? GetExpense(int id)
        {
            return _expenseRepository.GetExpense(id);
        }

        public IEnumerable<Expense> GetExpenses()
        {
            return _expenseRepository.GetExpenses();
        }

        public void UpdateExpense(Expense expense)
        {
            _expenseRepository.UpdateExpense(expense);
        }
    }
}
