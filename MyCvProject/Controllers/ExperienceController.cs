using Microsoft.AspNetCore.Mvc;
using MyCvProject.Models.Entities;
using MyCvProject.Repositories;

namespace MyCvProject.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly ExperienceRepository repo;

        public ExperienceController(ExperienceRepository _repo)
        {
            repo = _repo;
        }

        public IActionResult Index()
        {
            var values = repo.TGetAllList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience x)
        {
            repo.TAdd(x);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteExperience(int id)
        {
            var values = repo.TGetId(id);
            repo.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var values = repo.TGetId(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience x, int id)
        {
            var values = repo.TGetId(id);
            values.Meslek = x.Meslek;
            values.Alan = x.Alan;
            values.Aciklama = x.Aciklama;
            values.Tarih = x.Tarih;
            repo.TUpdate(values);
            return RedirectToAction("Index");
        }

    }
}
