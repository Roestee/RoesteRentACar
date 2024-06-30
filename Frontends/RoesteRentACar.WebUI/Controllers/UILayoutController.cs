using Microsoft.AspNetCore.Mvc;

namespace RoesteRentACar.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
