﻿using System;
using System.Text.Json;
using CarBook.Application.Dtos.CategoryDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
	public class _BlogDetailsCategoryComponentPartial :  ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public _BlogDetailsCategoryComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7060/api/Category");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonSerializer.Deserialize<List<ResultCategoryDto>>(jsonData);
				return View(values);
			}
			return View();
		}
	}
}

