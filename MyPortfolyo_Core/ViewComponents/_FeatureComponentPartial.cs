using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Core.DAL.Context;
using MyPortfolyo_Core.DAL.Entities;
using MyPortfolyo_Core.Models;

namespace Core_Demo.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {

        private readonly MyPortfolioContext context;
        public _FeatureComponentPartial(MyPortfolioContext _context)
        {
            context = _context;
        }
        public IViewComponentResult Invoke()
        {
            var values = new DashboardViewModel
            {
                Features = context.Features.ToList(),
                SocialMedias = context.SocialMedias.ToList()
            };
            return View(values);
        }
    }
}