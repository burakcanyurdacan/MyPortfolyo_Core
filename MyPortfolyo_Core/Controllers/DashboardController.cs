using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Core.DAL.Context;

namespace MyPortfolyo_Core.Controllers
{
    public class DashboardController : Controller
    {
        private readonly MyPortfolioContext context;
        public DashboardController(MyPortfolioContext _context)
        {
            context = _context;
        }

        private double CalcTaskPercent()
        {
            int totalTask = context.ToDoLists.Count();
            int completeTask = context.ToDoLists.Where(x => x.Status == true).Count();
            double percentage = Math.Round(((double)completeTask / totalTask) * 100, 0);
            return percentage;
        }

        public IActionResult Index()
        {
            ViewBag.taskPercentage = CalcTaskPercent();
            ViewBag.taskList = context.ToDoLists.ToList();
            ViewBag.aboutInfo = context.Abouts.FirstOrDefault();
            return View();
        }
    }
}