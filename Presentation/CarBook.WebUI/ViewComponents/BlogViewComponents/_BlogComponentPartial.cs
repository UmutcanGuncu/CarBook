using System;
using System.Text.Json;
using CarBook.Application.Dtos.BlogDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
	public class _BlogComponentPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public _BlogComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7060/api/Blog/last3BlogList");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonSerializer.Deserialize<List<Result3BlogDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}

