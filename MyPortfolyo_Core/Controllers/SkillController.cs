using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Core.DAL.Context;
using MyPortfolyo_Core.DAL.Entities;

namespace MyPortfolyo_Core.Controllers
{
    public class SkillController : Controller
    {
        private readonly MyPortfolioContext context;
        public SkillController(MyPortfolioContext _context)
        {
            context = _context;
        }

        public IActionResult ListSkills()
        {
            var values = context.Skills.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            skill.Title=skill.Title.ToUpper();
            context.Skills.Add(skill);
            context.SaveChanges();
            return RedirectToAction("ListSkills");
        }

        public IActionResult DeleteSkill(int id)
        {
            var value = context.Skills.Find(id);
            context.Skills.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ListSkills");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var value = context.Skills.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            context.Skills.Update(skill);
            context.SaveChanges();
            return RedirectToAction("ListSkills");
        }
    }
}
