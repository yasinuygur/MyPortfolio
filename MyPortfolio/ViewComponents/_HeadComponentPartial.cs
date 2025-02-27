using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewCompanents
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
