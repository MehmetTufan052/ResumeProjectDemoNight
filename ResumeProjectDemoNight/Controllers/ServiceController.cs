using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Entities;

namespace ResumeProjectDemoNight.Controllers
{
    public class ServiceController : Controller
    {
        private readonly ResumeContext _resumeContext;

        public ServiceController(ResumeContext resumeContext)
        {
            _resumeContext = resumeContext;
        }

        public IActionResult Index()
        {
            var list=_resumeContext.Services.ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var value = _resumeContext.Services.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            _resumeContext.Services.Update(service);
            _resumeContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int id)
        {
            var value = _resumeContext.Services.Find(id);
            _resumeContext.Services.Remove(value);
            _resumeContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateService(Service service)
        {
            _resumeContext.Services.Add(service);
            _resumeContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
