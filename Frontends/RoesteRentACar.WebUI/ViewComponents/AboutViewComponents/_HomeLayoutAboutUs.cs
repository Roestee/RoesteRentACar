﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RoesteRentACar.Dto.AboutDtos;

namespace RoesteRentACar.WebUI.ViewComponents.AboutViewComponents
{
    public class _HomeLayoutAboutUs: ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _HomeLayoutAboutUs(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7237/api/Abouts");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(jsonData);

                return View(values);
            }

            return View();
        }
    }
}
