using Microsoft.AspNetCore.Mvc;
using MyCvProject.Repositories;

namespace MyCvProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactRepository repo;

        public ContactController(ContactRepository _repo)
        {
            repo = _repo;
        }

        public IActionResult Index()
        {
            var values = repo.TGetAllList();
            return View(values);
        }

        public IActionResult DeleteContact(int id)
        {
            var message = repo.TGetId(id);
            repo.TDelete(message);
            return RedirectToAction("Index");
        }


    }
}
