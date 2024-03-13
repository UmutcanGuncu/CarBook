using System;
using System.Text.Json;
using CarBook.Application.Dtos.CarDtos;
using CarBook.Application.Dtos.PriceDtos;
using CarBook.WebUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class AdminCarController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

        public AdminCarController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task <IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7060/api/Pricing/pricingWithCar");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonSerializer.Deserialize<List<ResultPriceWithCarAndBrandDto>>(jsonData);
				return View(values);
			}
			return View();
		}
		[HttpGet]
		public IActionResult CreateCar()
		{
			
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateCar(CreateCarWithPricesViewModel model)
		{
			return RedirectToAction("Index");
		}
	}
}

