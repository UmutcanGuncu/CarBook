using System;
using System.Text.Json;
using CarBook.Application.Dtos.CarDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.CarListViewComponents
{
	public class _FiveCarsListComponentPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public _FiveCarsListComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7060/Car/listFiveBrand");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonSerializer.Deserialize<List<ResultFiveCarWithBrandsDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}

