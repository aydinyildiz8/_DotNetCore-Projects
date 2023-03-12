using Microsoft.AspNetCore.Mvc;
using MyCvProject.Context;
using System.Linq;

namespace MyCvProject.ViewComponents
{
    public class _ExperiencePartial : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public _ExperiencePartial(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _appDbContext.Experiences.ToList();
            return View(values);
        }
    }
}
