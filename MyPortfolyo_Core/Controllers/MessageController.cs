using Microsoft.AspNetCore.Mvc;
using MyPortfolyo_Core.DAL.Context;

namespace MyPortfolyo_Core.Controllers
{
    public class MessageController : Controller
    {
        private readonly MyPortfolioContext context;
        public MessageController(MyPortfolioContext _context)
        {
            context = _context;
        }

        public IActionResult Inbox()
        {
            var values = context.Messages.OrderByDescending(x=>x.SendDate).ToList();
            return View(values);
        }

        public IActionResult ChangeIsRead(int id)
        {
            var value = context.Messages.Find(id);
            if (value.IsRead == false)
            {
                value.IsRead = true;
            }
            else
            {
                value.IsRead = false;
            }
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = context.Messages.Find(id);
            context.Messages.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult MessageDetail(int id)
        {
            var value = context.Messages.Find(id);

            //Mesaj detayına girdiği için okundu bilgisi true olmalı.
            value.IsRead = true;
            context.Messages.Update(value);
            context.SaveChanges();

            return View(value);
        }
    }
}