using Microsoft.AspNetCore.Mvc;

namespace RoesteRentACar.WebUI.ViewComponents.HomeLayoutViewComponents
{
    public class _HomeLayoutLoader: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
