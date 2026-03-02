using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}