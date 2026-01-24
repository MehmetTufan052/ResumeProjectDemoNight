using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;

namespace ResumeProjectDemoNight.ViewComponents.DefaultViewComponents
{
    public class _DefaultExperienceComponentPartial:ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultExperienceComponentPartial(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var model = new ExperienceVM
            {
                Educations = _context.Educations.ToList(),
                Experiences = _context.Experiences.ToList()
            };
            return View(model);
        }

    }
}
