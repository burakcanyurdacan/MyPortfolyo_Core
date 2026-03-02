using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Core.DAL.Context;

namespace Core_Demo.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext context;
        public _FooterComponentPartial(MyPortfolioContext _context)
        {
            context = _context;
        }
        public IViewComponentResult Invoke()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }
    }
}