using Microsoft.AspNetCore.Mvc;
using MyCvProject.Context;
using System.Linq;

namespace MyCvProject.ViewComponents
{
    public class _CertificatePartial : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public _CertificatePartial(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _appDbContext.Certificates.ToList();
            return View(values);
        }
    }
}
