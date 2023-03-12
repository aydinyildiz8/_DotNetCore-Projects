using Microsoft.AspNetCore.Mvc;
using MyCvProject.Context;
using System.Linq;

namespace MyCvProject.ViewComponents
{
    public class _SocialMediaPartial : ViewComponent
    {

        private readonly AppDbContext _appDbContext;

        public _SocialMediaPartial(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _appDbContext.SocialMedia.Where(x => x.Durum == true).ToList();
            return View(values);
        }

    }
}