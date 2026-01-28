using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Entities;

namespace ResumeProjectDemoNight.Controllers
{
    public class SkillController : Controller
    {
        private readonly ResumeContext _resumeContext;

        public SkillController(ResumeContext resumeContext)
        {
            _resumeContext = resumeContext;
        }

        public IActionResult Index()
        {
            var list=_resumeContext.Skills.ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }

        // POST
        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            _resumeContext.Skills.Add(skill);
            _resumeContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
