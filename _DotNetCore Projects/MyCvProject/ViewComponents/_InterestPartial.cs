using Microsoft.AspNetCore.Mvc;
using MyCvProject.Context;
using System.Linq;

namespace MyCvProject.ViewComponents
{
    public class _InterestPartial : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public _InterestPartial(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _appDbContext.Interests.ToList();
            return View(values);
        }
    }
}
