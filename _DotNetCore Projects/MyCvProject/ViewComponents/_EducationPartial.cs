using Microsoft.AspNetCore.Mvc;
using MyCvProject.Context;
using System.Linq;

namespace MyCvProject.ViewComponents
{
    public class _EducationPartial : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public _EducationPartial(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _appDbContext.Educations.ToList();
            return View(values);
        }
    }
}
