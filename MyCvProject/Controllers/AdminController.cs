using Microsoft.AspNetCore.Mvc;
using MyCvProject.Models.Entities;
using MyCvProject.Repositories;

namespace MyCvProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly AdminRepository repo;

        public AdminController(AdminRepository _repo)
        {
            repo = _repo;
        }

        public IActionResult Index()
        {
            var values = repo.TGetAllList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddAdmin(Admin admin)
        {
            repo.TAdd(admin);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteAdmin(int id)
        {
            var admin = repo.TGetId(id);
            repo.TDelete(admin);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAdmin(int id)
        {
            var values = repo.TGetId(id);
            return View(values);
        }


        [HttpPost]
        public IActionResult UpdateAdmin(Admin x, int id)
        {
            var values = repo.TGetId(id);
            values.KullaniciAdi = x.KullaniciAdi;
            values.Sifre = x.Sifre;
            repo.TUpdate(values);
            return RedirectToAction("Index");
        }
    }
}
