using Microsoft.AspNetCore.Mvc;
using MyCvProject.Context;
using System.Linq;

namespace MyCvProject.ViewComponents
{
    public class _SkillsPartial : ViewComponent
    {
        private readonly AppDbContext _appDbContext;

        public _SkillsPartial(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IViewComponentResult Invoke()
        {
            var values = _appDbContext.Skills.ToList();
            return View(values);
        }
    }
}
