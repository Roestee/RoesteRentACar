using Microsoft.AspNetCore.Mvc;
namespace RoesteRentACar.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ServiceController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            ViewBag.link1 = "Hizmetler";
            ViewBag.title1 = "Hizmetlerimiz";

            return View();
        }
    }
}
