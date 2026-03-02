using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Core.DAL.Context;
using MyPortfolyo_Core.DAL.Entities;

namespace MyPortfolyo_Core.Controllers
{
    public class ContactController : Controller
    {
        private readonly MyPortfolioContext context;
        public ContactController(MyPortfolioContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            var value = context.Contacts.FirstOrDefault();
            if (value == null) 
            {
                value = new Contact() 
                {
                    Address = "",
                    Description = "",
                    Phone1 = "",
                    Phone2 = "",
                    Mail = "",
                    Title = ""
                };
                context.Contacts.Add(value);
                context.SaveChanges();
            }
            return View(value);
        }

        [HttpPost]
        public IActionResult Index(Contact model) 
        {
            var value = context.Contacts.FirstOrDefault();
            if (value != null) 
            {
                value.Title = model.Title;
                value.Description = model.Description;
                value.Phone1 = model.Phone1;
                value.Phone2 = "";
                value.Mail = model.Mail;
                value.Address = model.Address;

                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }    
    }
}