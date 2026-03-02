using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyo_Core.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
