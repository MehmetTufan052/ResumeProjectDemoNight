using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Entities;
using ResumeProjectDemoNight.Models;

namespace ResumeProjectDemoNight.ViewComponents.DefaultViewComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultAboutComponentPartial(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var model = new DefaultAboutVM
            {
                Abouts2 = _context.Abouts2.ToList(),
                Skills = _context.Skills.ToList()
            };

            return View(model);
        }

    }
}
