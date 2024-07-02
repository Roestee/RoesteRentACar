using Microsoft.AspNetCore.Mvc;

namespace RoesteRentACar.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.title1 = "Hakkımızda";
            ViewBag.link1 = "Hakkımızda";
            return View();
        }
    }
}
