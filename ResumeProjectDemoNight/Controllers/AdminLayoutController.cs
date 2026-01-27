using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeProjectDemoNight.Context;

namespace ResumeProjectDemoNight.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DashboardView()
        
        {
            using var context = new ResumeContext();



            var about = context.Abouts.FirstOrDefault();
            ViewBag.ProfileName = about?.NameSurname;
            

            var about2 = context.Abouts2.FirstOrDefault();
            ViewBag.Description = about2?.Description;
            ViewBag.ProfileImageUrl = about2?.ImageUrl;

            var projectCount = context.Portfolios.Count();
            ViewBag.CompletedProjectsCount = projectCount;

            var skills = context.Skills.ToList();
            

            return View(skills);
        }
    }
    
    
}
