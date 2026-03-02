using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Core.DAL.Context;

namespace MyPortfolyo_Core.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial:ViewComponent
    {
        private readonly MyPortfolioContext context;
        public _LayoutNavbarComponentPartial(MyPortfolioContext _context)
        {
            context = _context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount = context.ToDoLists.Where(x=>x.Status == false).Count();
            var values = context.ToDoLists.Where(x => x.Status == false).ToList();
            return View(values);
        }
    }
}