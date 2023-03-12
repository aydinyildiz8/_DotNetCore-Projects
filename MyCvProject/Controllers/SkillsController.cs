using Microsoft.AspNetCore.Mvc;
using MyCvProject.Models.Entities;
using MyCvProject.Repositories;

namespace MyCvProject.Controllers
{
    public class SkillsController : Controller
    {
        private readonly SkillsRepositrory repo;

        public SkillsController(SkillsRepositrory _repo)
        {
            repo = _repo;
        }

        public IActionResult Index()
        {
            var values = repo.TGetAllList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddSkills()
        {

            return View();
        }


        [HttpPost]
        public IActionResult AddSkills(Skill skill)
        {
            repo.TAdd(skill);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteSkills(int id)
        {
            var skill = repo.TGetId(id);
            repo.TDelete(skill);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSkills(int id)
        {
            var values = repo.TGetId(id);
            return View(values);
        }


        [HttpPost]
        public IActionResult UpdateSkills(Skill x, int id)
        {
            var values = repo.TGetId(id);
            values.Yetenek = x.Yetenek;
            values.Oran = x.Oran;
            repo.TUpdate(values);
            return RedirectToAction("Index");
        }


    }
}
