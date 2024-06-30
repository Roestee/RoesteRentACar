using Microsoft.AspNetCore.Mvc;

namespace RoesteRentACar.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
