using AgriculturePresentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace AgriculturePresentation.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductChart()
        {
            List<ProductClass> productClasses = new List<ProductClass>();
            productClasses.Add(new ProductClass
            {
                productname = "Buğday",
                productvalue = 850
            });

            productClasses.Add(new ProductClass
            {
                productname = "Mercimek",
                productvalue = 400
            });


            productClasses.Add(new ProductClass
            {
                productname = "Arpa",
                productvalue = 600
            });


            productClasses.Add(new ProductClass
            {
                productname = "Prinç",
                productvalue = 350
            });


            productClasses.Add(new ProductClass
            {
                productname = "Domates",
                productvalue = 470
            });

            return Json(new { jsonlist = productClasses });
        }
    }
}
