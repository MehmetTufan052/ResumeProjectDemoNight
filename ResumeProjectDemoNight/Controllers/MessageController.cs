using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Entities;

namespace ResumeProjectDemoNight.Controllers
{
    public class MessageController : Controller
    {
        private readonly ResumeContext _context;

        public MessageController(ResumeContext context)
        {
            _context = context;
        }

        public IActionResult MessageList()
        {
            var values = _context.Messages.ToList();
            return View(values);
        }


        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            message.SendDate = DateTime.Now;
            message.IsRead = false;

            _context.Messages.Add(message);
            _context.SaveChanges();

            TempData["MessageStatus"] = true;

            return RedirectToAction("Index", "Default");
        }

        public IActionResult DeleteMessage(int id)
        {
            var value=_context.Messages.Find(id);
            _context.Messages.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("MessageList");
        }
    }
}
