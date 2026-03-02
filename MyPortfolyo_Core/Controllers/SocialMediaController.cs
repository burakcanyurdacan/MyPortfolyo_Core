using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Core.DAL.Context;
using MyPortfolyo_Core.DAL.Entities;

namespace MyPortfolyo_Core.Controllers
{
    public class SocialMediaController : Controller
    {
        private readonly MyPortfolioContext context;
        public SocialMediaController(MyPortfolioContext _context)
        {
            context = _context;
        }

        public IActionResult ListSocialMedias()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSocialMedias()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedias(SocialMedia socialMedia)
        {
            context.SocialMedias.Add(socialMedia);
            context.SaveChanges();
            return RedirectToAction("ListSocialMedias");
        }

        public IActionResult DeleteSocialMedias(int id)
        {
            var value = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ListSocialMedias");

        }

        [HttpGet]
        public IActionResult UpdateSocialMedias(int id)
        {
            var value = context.SocialMedias.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedias(SocialMedia socialMedia)
        {
            context.SocialMedias.Update(socialMedia);
            context.SaveChanges();
            return RedirectToAction("ListSocialMedias");
        }
    }
}