using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyCvProject.Models.Entities;
using MyCvProject.Repositories;

namespace MyCvProject.Controllers
{
   
    public class AboutController : Controller
    {
        private readonly AboutRepository repo;

        public AboutController(AboutRepository _repo)
        {
            repo = _repo;
        }

        public IActionResult Index()
        {
            var values = repo.TGetAllList();
            return View(values);
        }


        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = repo.TGetId(id);
            return View(values);
        }


        [HttpPost]
        public IActionResult UpdateAbout(About x, int id)
        {
            var values = repo.TGetId(id);
            values.Ad = x.Ad;
            values.Soyad = x.Soyad;
            values.Adres = x.Adres;
            values.Telefon = x.Telefon;
            values.Mail = x.Mail;
            values.Meslek = x.Meslek;
            values.Aciklama = x.Aciklama;
            values.ResimUrl = x.ResimUrl;

            repo.TUpdate(values);
            return RedirectToAction("Index");
        }
    }
}
