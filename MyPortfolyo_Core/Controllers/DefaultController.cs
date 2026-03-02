using Microsoft.AspNetCore.Mvc;

namespace Core_Demo.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
