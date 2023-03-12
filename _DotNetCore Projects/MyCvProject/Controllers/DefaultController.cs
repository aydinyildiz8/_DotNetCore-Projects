using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCvProject.Context;
using MyCvProject.Models.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MyCvProject.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public DefaultController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public PartialViewResult _ContactPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult _ContactPartial(Contact _message)
        {
            _message.Tarih = DateTime.Now;
            _appDbContext.Contacts.Add(_message);
            _appDbContext.SaveChanges();
            return PartialView("Index","Default");
        }

    }
}
