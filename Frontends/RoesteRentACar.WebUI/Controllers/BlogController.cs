using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RoesteRentACar.Dto.BlogDtos;

namespace RoesteRentACar.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.link1 = "Blog";
            ViewBag.title1 = "Yazarlarımızın Blogları";

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7237/api/Blog/BlogListWithDetail");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBlogWithDetailDto>>(jsonData);

                return View(values);
            }
            return View();
        }

        public IActionResult BlogDetail(int id)
        {
            ViewBag.link1 = "Blog";
            ViewBag.link2 = "Blog Detayları";
            ViewBag.title1 = "Blog Detayı ve Yorumlar";
            ViewBag.blogId = id;

            return View();
        }
    }
}
