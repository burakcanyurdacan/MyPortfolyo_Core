using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Core.DAL.Context;
using MyPortfolyo_Core.DAL.Entities;

namespace MyPortfolyo_Core.Controllers
{
    public class FeatureController : Controller
    {
        private readonly MyPortfolioContext context;
        public FeatureController(MyPortfolioContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            var feature = context.Features.FirstOrDefault();
            if (feature == null)
            {
                feature = new Feature()
                {
                    Title = "",
                    Description = ""
                };
                context.Features.Add(feature);
                context.SaveChanges();
            }
            return View(feature);
        }

        [HttpPost]
        public IActionResult Index(Feature model)
        {
            var feature = context.Features.FirstOrDefault();
            if (feature != null)
            {
                feature.Title = model.Title;
                feature.Description = model.Description;
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}