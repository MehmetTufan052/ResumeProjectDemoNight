using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeProjectDemoNight.Context;

namespace ResumeProjectDemoNight.ViewComponents.DefaultViewComponents
{
    public class _DefaultHeaderComponentPartial:ViewComponent
    {
        private readonly ResumeContext _context; 
        public _DefaultHeaderComponentPartial(ResumeContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.TotalProjectsCount = _context.Portfolios.Count();
            ViewBag.UnreadMessageCount = _context.Messages.Count(x => x.IsRead == false);

            return View();
        }

    }
}
