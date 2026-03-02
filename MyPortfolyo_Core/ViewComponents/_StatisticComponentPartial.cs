using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}