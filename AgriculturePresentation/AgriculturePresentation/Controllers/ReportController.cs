using AgriculturePresentation.Models;
using ClosedXML.Excel;
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AgriculturePresentation.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticReport()
        {
            ExcelPackage excelPackage = new ExcelPackage();
            var workBook = excelPackage.Workbook.Worksheets.Add("Dosya1");

            workBook.Cells[1, 1].Value = "Ürün Adı";
            workBook.Cells[1, 2].Value = "Ürün Kategorisi";
            workBook.Cells[1, 3].Value = "Ürün Stok";

            workBook.Cells[2, 1].Value = "Mercimek";
            workBook.Cells[2, 2].Value = "Bakliyat";
            workBook.Cells[2, 3].Value = "800 kg";

            workBook.Cells[3, 1].Value = "Buğday";
            workBook.Cells[3, 2].Value = "Bakliyat";
            workBook.Cells[3, 3].Value = "1850 kg";

            workBook.Cells[4, 1].Value = "Patates";
            workBook.Cells[4, 2].Value = "Sebze";
            workBook.Cells[4, 3].Value = "2000 kg";

            var bytes = excelPackage.GetAsByteArray();
            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ÜrünRaporu.xlsx");
        }


        public List<ContactModel> ContactList()
        {
            List<ContactModel> contactModels = new List<ContactModel>();
            using (var context = new AgricultureContext())
            {
                contactModels = context.contacts.Select(x => new ContactModel
                {
                    ContactId = x.ContactId,
                    ContactName = x.Name,
                    ContactDate = x.Date,
                    ContactMail = x.EMail,
                    ContactMessage = x.Message

                }).ToList();
            }
            return contactModels;
        }

        public IActionResult ContactReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Mesaj Listesi");
                workSheet.Cell(1, 1).Value = "Mesaj ID";
                workSheet.Cell(1, 2).Value = "Mesajı Gönderen";
                workSheet.Cell(1, 3).Value = "Mail Adresi";
                workSheet.Cell(1, 4).Value = "Mesaj İçeriği";
                workSheet.Cell(1, 5).Value = "Mesaj Tarihi";

                int contactRowCount = 2;
                foreach (var item in ContactList())
                {
                    workSheet.Cell(contactRowCount, 1).Value = item.ContactId;
                    workSheet.Cell(contactRowCount, 2).Value = item.ContactName;
                    workSheet.Cell(contactRowCount, 3).Value = item.ContactMail;
                    workSheet.Cell(contactRowCount, 4).Value = item.ContactMessage;
                    workSheet.Cell(contactRowCount, 5).Value = item.ContactDate;
                    contactRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Mesaj Raporu.xlsx");
                }

            }
        }

        public List<AnnouncementModel> AnnouncementList()
        {
            List<AnnouncementModel> announcementModel = new List<AnnouncementModel>();
            using (var context = new AgricultureContext())
            {
                announcementModel = context.announcements.Select(x => new AnnouncementModel
                {
                    AnnouncementId = x.AnnouncementId,
                    Title = x.Title,
                    Date = x.Date,
                    Status = x.Status,
                    Description = x.Description

                }).ToList();
            }
            return announcementModel;
        }

        public IActionResult AnnouncementReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Duyuru Listesi");
                workSheet.Cell(1, 1).Value = "Duyuru ID";
                workSheet.Cell(1, 2).Value = "Duyuru Başlığı";
                workSheet.Cell(1, 3).Value = "Duyuru Tarihi";
                workSheet.Cell(1, 4).Value = "Duyuru İçeriği";
                workSheet.Cell(1, 5).Value = "Durum";

                int annauncementtRowCount = 2;
                foreach (var item in AnnouncementList())
                {
                    workSheet.Cell(annauncementtRowCount, 1).Value = item.AnnouncementId;
                    workSheet.Cell(annauncementtRowCount, 2).Value = item.Title;
                    workSheet.Cell(annauncementtRowCount, 3).Value = item.Date;
                    workSheet.Cell(annauncementtRowCount, 4).Value = item.Description;
                    workSheet.Cell(annauncementtRowCount, 5).Value = item.Status;
                    annauncementtRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Duyuru Raporu.xlsx");
                }

            }
        }
    }
}
