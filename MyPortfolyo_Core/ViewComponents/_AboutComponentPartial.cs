using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Core.DAL.Context;

namespace Core_Demo.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext context;
        public _AboutComponentPartial(MyPortfolioContext _context)
        {
            context = _context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.subDesc = context.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = context.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }
    }
}