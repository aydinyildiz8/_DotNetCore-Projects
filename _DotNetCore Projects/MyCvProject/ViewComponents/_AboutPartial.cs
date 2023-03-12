using Microsoft.AspNetCore.Mvc;
using MyCvProject.Context;
using System.Linq;

namespace MyCvProject.ViewComponents
{
    public class _AboutPartial :ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public _AboutPartial(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _appDbContext.Abouts.ToList();
            return View(values);
        }
    }
}
