using Microsoft.AspNetCore.Mvc;
using MyCvProject.Models.Entities;
using MyCvProject.Repositories;

namespace MyCvProject.Controllers
{
    public class SocialMediaController : Controller
    {
        private readonly SocialMediaRepository repo;

        public SocialMediaController(SocialMediaRepository _repo)
        {
            repo = _repo;
        }

        public IActionResult Index()
        {
            var values = repo.TGetAllList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia socialMedia)
        {
            repo.TAdd(socialMedia);
            return RedirectToAction("Index");
        }


        public IActionResult DeleteSocialMedia(int id)
        {
            var socialMedia = repo.TGetId(id);
            repo.TDelete(socialMedia);
            return RedirectToAction("Index");
        }

        public IActionResult StatusSocialMedia(int id)
        {
            var socialMedia = repo.TGetId(id);
            if (socialMedia.Durum == false)
            {
                socialMedia.Durum = true;
                repo.TUpdate(socialMedia);
                return RedirectToAction("Index");
            }
            socialMedia.Durum = false;
            repo.TUpdate(socialMedia);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var values = repo.TGetId(id);
            return View(values);
        }


        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia x, int id)
        {
            var values = repo.TGetId(id);
            values.Ad = x.Ad;
            values.Link = x.Link;
            values.Ikon = x.Ikon;
            repo.TUpdate(values);
            return RedirectToAction("Index");
        }
    }
}
