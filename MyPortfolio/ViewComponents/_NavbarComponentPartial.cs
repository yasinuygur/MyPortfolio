using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewCompanents
{
    public class _NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
