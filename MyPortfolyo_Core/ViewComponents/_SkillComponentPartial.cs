using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Core.DAL.Context;

namespace Core_Demo.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        private readonly MyPortfolioContext context;
        public _SkillComponentPartial(MyPortfolioContext _context)
        {
            context = _context;
        }
        public IViewComponentResult Invoke()
        {
            var values= context.Skills.ToList();
            return View(values);
        }
    }
}