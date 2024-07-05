using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RoesteRentACar.Dto.CategoryDtos;

namespace RoesteRentACar.WebUI.ViewComponents.BlogViewComponents
{
    public class _HomeLayoutBlogDetailCategories: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HomeLayoutBlogDetailCategories(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7237/api/Categories");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);

                return View(values);
            }

            return View();
        }
    }
}
