using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Core.DAL.Context;

namespace Core_Demo.ViewComponents
{
    public class _TestimonialsComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext context;
        public _TestimonialsComponentPartial(MyPortfolioContext _context)
        {
            context = _context;
        }

        public IViewComponentResult Invoke()
        {
            var testimonials = context.Testimonials.ToList();
            return View(testimonials);
        }
    }
}