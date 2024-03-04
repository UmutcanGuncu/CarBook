using System;
using System.Text.Json;
using CarBook.Application.Dtos.TagCloudDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
	public class _BlogDetailTagCloudByBlogComponentPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public _BlogDetailTagCloudByBlogComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task <IViewComponentResult> InvokeAsync(Guid blogId)
		{
			var client = _httpClientFactory.CreateClient();
			var repsonseMessage = await client.GetAsync("https://localhost:7060/api/TagCloud/byblogidlist/" + blogId);
			if (repsonseMessage.IsSuccessStatusCode)
			{
				var jsonData = await repsonseMessage.Content.ReadAsStringAsync();
				var values = JsonSerializer.Deserialize<List<ResultTagCloudDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}

