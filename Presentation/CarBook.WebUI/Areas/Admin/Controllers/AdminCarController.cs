using System;
using System.Text.Json;
using CarBook.Application.Dtos.BrandDtos;
using CarBook.Application.Dtos.CarDtos;
using CarBook.Application.Dtos.PriceDtos;
using CarBook.WebUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
		public async Task<IActionResult> CreateCar()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7060/api/Brand");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonSerializer.Deserialize<List<ResultBrandDto>>(jsonData);
				ViewBag.BrandData = new SelectList(values, "id", "name");
			}
			
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateCar(CreateCarWithPricesViewModel model)
		{
			if(model.BigImage != null && model.CoverImage != null)
			{
				string coverImageExtension = Path.GetExtension(model.CoverImage.FileName);
                string bigImageExtension = Path.GetExtension(model.BigImage.FileName);

				string coverImageName = Guid.NewGuid() + coverImageExtension;
				string bigImageName = Guid.NewGuid() + bigImageExtension;

				string coverImagePath = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/Admin/horizontal/assets/images/{coverImageName}");
                string bigImagePath = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/Admin/horizontal/assets/images/{bigImageName}");

				using var coverImageStream = new FileStream(coverImagePath, FileMode.Create);
                using var bigImageStream = new FileStream(bigImagePath, FileMode.Create);
				await model.CoverImage.CopyToAsync(coverImageStream);
				await model.BigImage.CopyToAsync(bigImageStream);
				

            }
            return RedirectToAction("Index","Home");
		}
	}
}

