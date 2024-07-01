using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RoesteRentACar.Dto.VehicleDtos;

namespace RoesteRentACar.WebUI.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public VehicleController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7237/api/Vehicles/VehicleListWithDetail");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultVehicleWithDetailDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
