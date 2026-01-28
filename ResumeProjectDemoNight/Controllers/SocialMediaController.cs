using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Entities;

namespace ResumeProjectDemoNight.Controllers
{
    public class SocialMediaController : Controller
    {
        private readonly ResumeContext _resumeContext;

        public SocialMediaController(ResumeContext resumeContext)
        {
            _resumeContext = resumeContext;
        }

        public IActionResult Index()
        {
            var model = _resumeContext.Abouts.FirstOrDefault();

            if (model == null)
            {
                return Content("Veri bulunamadı.");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var value = _resumeContext.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia(About about)
        {
            var value = _resumeContext.Abouts.FirstOrDefault(x => x.AboutId == about.AboutId);

            if (value != null)
            {
                // 2. Sadece değişmesini istediğimiz alanları güncelliyoruz
                value.SocialMedia1 = about.SocialMedia1;
                value.SocialMedia2 = about.SocialMedia2;
                value.SocialMedia3 = about.SocialMedia3;

                // Description alanına dokunmadığımız için o eski değerini koruyacak
                _resumeContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(about);
        }
    }
    
}
