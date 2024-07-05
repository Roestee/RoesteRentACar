using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RoesteRentACar.Dto.TagCloudDtos;

namespace RoesteRentACar.WebUI.ViewComponents.BlogViewComponents
{
    public class _HomeLayoutBlogDetailTagClouds: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HomeLayoutBlogDetailTagClouds(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync( $"https://localhost:7237/api/TagCloud/GetTagCloudsByBlogId?blogId={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTagCloudDto>>(jsonData);
                return View(values);
            }
            
            return View();
        }
    }
}
