using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Core.DAL.Context;

namespace Core_Demo.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext context;
        public _PortfolioComponentPartial(MyPortfolioContext _context)
        {
            context = _context;
        }

        public IViewComponentResult Invoke()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }
    }
}