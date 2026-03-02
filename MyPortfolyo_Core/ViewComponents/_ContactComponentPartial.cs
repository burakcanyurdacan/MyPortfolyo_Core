using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Core.DAL.Context;

namespace Core_Demo.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext context;
        public _ContactComponentPartial(MyPortfolioContext _context)
        {
            context = _context;
        }

        public IViewComponentResult Invoke()
        {
            var value = context.Contacts.FirstOrDefault();
            return View(value);
        }
    }
}