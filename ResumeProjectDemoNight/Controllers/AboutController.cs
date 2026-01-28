using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeProjectDemoNight.Context;

namespace ResumeProjectDemoNight.Controllers
{
    public class AboutController : Controller
    {
        private readonly ResumeContext _context;

        public AboutController(ResumeContext resumeContext)
        {
            _context = resumeContext;
        }

        public IActionResult Index()
        {
            var about = _context.Abouts.FirstOrDefault();
            var about2 = _context.Abouts2.FirstOrDefault();

            ViewBag.AboutId = about?.AboutId;
            ViewBag.NameSurname = about?.NameSurname;
            ViewBag.ImageUrl = about?.ImageUrl;
            ViewBag.Description = about2?.Description;

            return View();
        }
    }
}
