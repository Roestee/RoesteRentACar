using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RoesteRentACar.Dto.VehicleDtos;

namespace RoesteRentACar.WebUI.ViewComponents.HomeLayoutViewComponents
{
    public class _HomeLayoutLastFiveVehicleWithDetail: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HomeLayoutLastFiveVehicleWithDetail(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7237/api/Vehicles/VehicleListWithDetailWithCount?count=5");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultVehicleWithDetailWithCountDto>>(jsonData);
                return View(values);
            }

            return View();
        }

    }
}
