using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.ViewComponents
{
    public class _NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
