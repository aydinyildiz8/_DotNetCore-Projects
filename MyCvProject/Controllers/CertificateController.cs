using Microsoft.AspNetCore.Mvc;
using MyCvProject.Models.Entities;
using MyCvProject.Repositories;

namespace MyCvProject.Controllers
{
    public class CertificateController : Controller
    {
        private readonly CertificateRepository repo;

        public CertificateController(CertificateRepository _repo)
        {
            repo = _repo;
        }

        public IActionResult Index()
        {
            var values = repo.TGetAllList();
            return View(values);
        }


        [HttpGet]
        public IActionResult AddCertificate()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddCertificate(Certificate certificate)
        {
            repo.TAdd(certificate);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteCertificate(int id)
        {
            var skill = repo.TGetId(id);
            repo.TDelete(skill);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCertificate(int id)
        {
            var values = repo.TGetId(id);
            return View(values);
        }


        [HttpPost]
        public IActionResult UpdateCertificate(Certificate x, int id)
        {
            var values = repo.TGetId(id);
            values.SertifikaAdı = x.SertifikaAdı;
            values.VerenKurulus = x.VerenKurulus;
            values.Aciklama = x.Aciklama;
            repo.TUpdate(values);
            return RedirectToAction("Index");
        }
    }
}
