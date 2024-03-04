using System;
using System.Text.Json;
using CarBook.Application.Dtos.AuthorDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
	public class _BlogDetailAuthorComponentPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _BlogDetailAuthorComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync(Guid authorId, Guid blogId)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7060/api/Author/byBlog/" + authorId + "/" + blogId);
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var value = JsonSerializer.Deserialize<ResultAuthorDto>(jsonData);
				return View(value);
			}
			return View();
		}
	}
}
	


