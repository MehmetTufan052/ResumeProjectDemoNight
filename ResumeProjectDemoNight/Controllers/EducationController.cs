using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Entities;

namespace ResumeProjectDemoNight.Controllers
{
    public class EducationController : Controller
    {
        private readonly ResumeContext _resumeContext;

        public EducationController(ResumeContext resumeContext)
        {
            _resumeContext = resumeContext;
        }

        public IActionResult Index()
        {
            var list=_resumeContext.Educations.ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult CreateEducation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEducation(Education education)
        {
            _resumeContext.Educations.Add(education);
            _resumeContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
