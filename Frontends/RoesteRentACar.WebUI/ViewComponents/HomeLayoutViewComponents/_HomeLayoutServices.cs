using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RoesteRentACar.Dto.ServiceDtos;

namespace RoesteRentACar.WebUI.ViewComponents.HomeLayoutViewComponents
{
    public class _HomeLayoutServices: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HomeLayoutServices(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseResult = await client.GetAsync("https://localhost:7237/api/Services");
            if (responseResult.IsSuccessStatusCode)
            {
                var jsonData = await responseResult.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
