using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.ViewComponents
{
    public class _DashboardOverviewPartial : ViewComponent
    {
        AgricultureContext c = new AgricultureContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.teamCount = c.teams.Count();
            ViewBag.serviceCount = c.services.Count();
            ViewBag.messageCount = c.contacts.Count();
            ViewBag.currentMonthMessage = 3;

            ViewBag.announcementTrue = c.announcements.Where(x => x.Status == true).Count();
            ViewBag.announcementFalse = c.announcements.Where(x => x.Status == false).Count();

            ViewBag.urunPazarlama = c.teams.Where(x => x.Title == "Ürün Pazarlama").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.bakliyatYonetimi = c.teams.Where(x => x.Title == "Bakliyat Yönetimi").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.sutUretici = c.teams.Where(x => x.Title == "Süt Üreticisi").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.gubreYonetimi = c.teams.Where(x => x.Title == "Gübre Yönetimi").Select(y => y.PersonName).FirstOrDefault();
            return View();
        }
    }
}
