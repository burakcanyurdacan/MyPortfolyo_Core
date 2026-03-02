using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo_Core.ViewComponents.LayoutViewComponents
{
    public class _LayoutSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var currentController = RouteData.Values["controller"]?.ToString();
            var currentAction = RouteData.Values["action"]?.ToString();

            ViewBag.CurrentController = currentController;
            ViewBag.CurrentAction = currentAction;
            return View();
        }
    }
}