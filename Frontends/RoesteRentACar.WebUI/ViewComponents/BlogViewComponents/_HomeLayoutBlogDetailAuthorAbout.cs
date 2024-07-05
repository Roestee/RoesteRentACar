using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RoesteRentACar.Dto.BlogDtos;

namespace RoesteRentACar.WebUI.ViewComponents.BlogViewComponents
{
    public class _HomeLayoutBlogDetailAuthorAbout: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HomeLayoutBlogDetailAuthorAbout(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7237/api/Blog/GetBlogWithDetail?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<ResultBlogWithDetailDto>(jsonData);

                return View(value);
            }

            return View();
        }
    }
}
