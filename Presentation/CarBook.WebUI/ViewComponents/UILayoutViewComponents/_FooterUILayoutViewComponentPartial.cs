﻿using System;
using System.Text.Json;
using CarBook.Application.Dtos.FooterAdressDto;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.UILayoutViewComponents
{
	public class _FooterUILayoutViewComponentPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public _FooterUILayoutViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7060/api/FooterAdress");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var value = JsonSerializer.Deserialize<List<ResultFooterAdressDto>>(jsonData);
				return View(value);
			}
			return View();
		}
	}
}

