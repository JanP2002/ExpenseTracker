using ExpenseTracker.Models;
using ExpenseTracker.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Repositories
{
    public class DataBaseExpenseRepository : IExpenseRepository
    {
        private readonly AppDbContext _dbContext;

        public DataBaseExpenseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddExpense(Expense expense)
        {
            _dbContext.Expenses.Add(expense);
            _dbContext.SaveChanges();
        }

        public void DeleteExpense(int id)
        {
            var expense = _dbContext.Expenses
                .FirstOrDefault(x => x.Id == id);

            if (expense == null)
            {
                return;
            }

            _dbContext.Expenses.Remove(expense);

            _dbContext.SaveChanges();
        }

        public Expense? GetExpense(int id)
        {
            var expense = _dbContext.Expenses
                .FirstOrDefault(x => x.Id == id);

            return expense;
        }

        public IEnumerable<Expense> GetExpenses()
        {
            var expenses = _dbContext.Expenses
                .ToList();

            return expenses;
        }

        public void UpdateExpense(Expense expense)
        {
            var existingExpense = _dbContext.Expenses
           .FirstOrDefault(x => x.Id == expense.Id);

            if (existingExpense == null)
            {
                return;
            }

            existingExpense.Value = expense.Value;
            existingExpense.Description = expense.Description;

            _dbContext.SaveChanges();
        }
    }
}
