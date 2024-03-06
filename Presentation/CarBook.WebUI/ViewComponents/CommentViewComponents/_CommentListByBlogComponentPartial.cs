using System;
using System.Text.Json;
using CarBook.Application.Dtos.CommentDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.CommentViewComponents
{
	public class _CommentListByBlogComponentPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public _CommentListByBlogComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task <IViewComponentResult> InvokeAsync(Guid blogId)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:5164/api/Comment/getCommentByBlogIdList/"+blogId);
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonSerializer.Deserialize<List<ResultBlogDetailCommentsDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}

