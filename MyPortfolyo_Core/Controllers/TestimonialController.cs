using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Core.DAL.Context;
using MyPortfolyo_Core.DAL.Entities;

namespace MyPortfolyo_Core.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly MyPortfolioContext context;
        public TestimonialController(MyPortfolioContext _context)
        {
            context = _context;
        }

        public IActionResult ListTestimonials()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            context.Testimonials.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("ListTestimonials");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            context.Testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ListTestimonials");
        }
    }
}