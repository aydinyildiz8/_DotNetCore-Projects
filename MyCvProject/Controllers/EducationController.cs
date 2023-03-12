using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyCvProject.Models.Entities;
using MyCvProject.Repositories;

namespace MyCvProject.Controllers
{
    public class EducationController : Controller
    {
        private readonly EducationRepository repo;

        public EducationController(EducationRepository _repo)
        {
            repo = _repo;
        }


        public IActionResult Index()
        {
            var values = repo.TGetAllList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddEducation()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddEducation(Education education)
        {
            if (!ModelState.IsValid)
            {
                return View("AddEducation");
            }

            repo.TAdd(education);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteEducation(int id)
        {
            var skill = repo.TGetId(id);
            repo.TDelete(skill);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult UpdateEducation(int id)
        {
            var values = repo.TGetId(id);
            return View(values);
        }


        [HttpPost]
        public IActionResult UpdateEducation(Education x, int id)
        {
            var values = repo.TGetId(id);
            values.Okul = x.Okul;
            values.Fakülte = x.Fakülte;
            values.Bölüm = x.Bölüm;
            values.Gno = x.Gno;
            values.MezuniyetTarihi = x.MezuniyetTarihi;
            repo.TUpdate(values);
            return RedirectToAction("Index");
        }

    }
}
