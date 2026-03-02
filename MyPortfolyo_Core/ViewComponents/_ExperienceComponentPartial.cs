using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Core.DAL.Context;

namespace Core_Demo.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        private readonly MyPortfolioContext context;
        public _ExperienceComponentPartial(MyPortfolioContext _context)
        {
            context = _context;
        }
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences
                .OrderByDescending(x => x.EndDate ?? DateTime.MaxValue)
                .ThenByDescending(x => x.StartDate)
                .ToList();
            return View(values);
        }
    }
}