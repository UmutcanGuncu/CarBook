using System;
using System.Text.Json;
using CarBook.Application.Dtos.AboutDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.AboutViewComponents
{
	public class _AboutComponentPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public _AboutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7060/api/About");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData =  await responseMessage.Content.ReadAsStringAsync();
				var values = JsonSerializer.Deserialize<List<ResultAboutDto>>(jsonData);
				return View(values);
			}
			return View();

		}
	}
}

