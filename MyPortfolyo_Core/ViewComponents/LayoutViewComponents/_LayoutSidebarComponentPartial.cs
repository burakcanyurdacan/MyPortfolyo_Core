using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Core.DAL.Context;

namespace MyPortfolyo_Core.ViewComponents.LayoutViewComponents
{
    public class _LayoutSidebarComponentPartial:ViewComponent
    {
        private readonly MyPortfolioContext context;
        public _LayoutSidebarComponentPartial(MyPortfolioContext _context)
        {
            context = _context;
        }

        public IViewComponentResult Invoke()
        {
            var currentController = RouteData.Values["controller"]?.ToString();
            var currentAction = RouteData.Values["action"]?.ToString();
            var messageInfo = context.Messages.Where(x => x.IsRead == false).Count();

            ViewBag.CurrentController = currentController;
            ViewBag.CurrentAction = currentAction;
            ViewBag.MessageInfo = messageInfo;
            return View();
        }
    }
}