using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Core.DAL.Context;
using MyPortfolyo_Core.DAL.Entities;

namespace MyPortfolyo_Core.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly MyPortfolioContext context;
        public PortfolioController(MyPortfolioContext _context)
        {
            context = _context;
        }

        public IActionResult ListPortfolios()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            context.Portfolios.Add(portfolio);
            context.SaveChanges();
            return RedirectToAction("ListPortfolios");
        }

        public IActionResult DeletePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);
            context.Portfolios.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ListPortfolios");
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            context.Portfolios.Update(portfolio);
            context.SaveChanges();
            return RedirectToAction("ListPortfolios");
        }
    }
}