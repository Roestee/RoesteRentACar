using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RoesteRentACar.Dto.BlogDtos;

namespace RoesteRentACar.WebUI.ViewComponents.HomeLayoutViewComponents
{
    public class _HomeLayoutLastThreeBlogWithDetail: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HomeLayoutLastThreeBlogWithDetail(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7237/api/Blog/BlogListWithDetailWithCount?count=3");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBlogWithDetailWithCountDto>>(jsonData);
                return View(values);
            }

            return View();
        }
    }
}
