using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Entities;

namespace ResumeProjectDemoNight.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly ResumeContext _resumeContext;

        public TestimonialController(ResumeContext resumeContext)
        {
            _resumeContext = resumeContext;
        }

        public IActionResult ListTestimonials()
        {
            var list = _resumeContext.Testimonials.ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            _resumeContext.Testimonials.Add(testimonial);
            _resumeContext.SaveChanges();
            return RedirectToAction("ListTestimonials");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var value = _resumeContext.Testimonials.Find(id);
            _resumeContext.Testimonials.Remove(value);
            _resumeContext.SaveChanges();
            return RedirectToAction("ListTestimonials");
        }

        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var value = _resumeContext.Testimonials.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _resumeContext.Testimonials.Update(testimonial);
            _resumeContext.SaveChanges();
            return RedirectToAction("ListTestimonials");
        }
    }
}
