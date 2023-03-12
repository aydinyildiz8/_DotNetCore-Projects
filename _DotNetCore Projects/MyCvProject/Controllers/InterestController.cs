using Microsoft.AspNetCore.Mvc;
using MyCvProject.Models.Entities;
using MyCvProject.Repositories;

namespace MyCvProject.Controllers
{
    public class InterestController : Controller
    {
        private readonly InterestRepository repo;

        public InterestController(InterestRepository _repo)
        {
            repo = _repo;
        }

        public IActionResult Index()
        {
            var values = repo.TGetAllList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddInterest()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddInterest(Interest ınterest)
        {
            repo.TAdd(ınterest);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteInterest(int id)
        {
            var ınterest = repo.TGetId(id);
            repo.TDelete(ınterest);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateInterest(int id)
        {
            var values = repo.TGetId(id);
            return View(values);
        }


        [HttpPost]
        public IActionResult UpdateInterest(Interest x, int id)
        {
            var values = repo.TGetId(id);
            values.Hobi = x.Hobi;
            values.Aciklama = x.Aciklama;
            repo.TUpdate(values);
            return RedirectToAction("Index");
        }
    }
}
