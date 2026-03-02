using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Core.DAL.Context;
using MyPortfolyo_Core.DAL.Entities;

namespace MyPortfolyo_Core.Controllers
{
    public class AboutController : Controller
    {
        private readonly MyPortfolioContext context;
        public AboutController(MyPortfolioContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            var value = context.Abouts.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}