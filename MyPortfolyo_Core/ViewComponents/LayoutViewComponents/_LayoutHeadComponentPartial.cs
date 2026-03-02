using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo_Core.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}