using ExpenseTracker.Models;
using ExpenseTracker.Services;
using ExpenseTracker.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExpenseTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IExpenseService _expenseService;

        public HomeController(ILogger<HomeController> logger, IExpenseService expenseService)
        {
            _logger = logger;
            _expenseService = expenseService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Expenses()
        {
            var allExpenses = _expenseService.GetExpenses();
            return View(allExpenses);
        }
        public IActionResult CreateEditExpense()
        {
            return View();
        }
        public IActionResult CreateEditExpenseForm(CreateExpenseDto expense)
        {
            _expenseService.AddExpense(expense);
            return RedirectToAction("Expenses");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
