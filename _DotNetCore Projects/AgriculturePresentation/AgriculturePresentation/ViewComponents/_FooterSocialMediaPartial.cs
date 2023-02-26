using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
    public class _FooterSocialMediaPartial : ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;

        public _FooterSocialMediaPartial(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _socialMediaService.GetListAll();
            return View(values);
        }
    }
}
