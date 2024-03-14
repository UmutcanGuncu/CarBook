﻿using System;
using System.Text;
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
			//Resim kaydetme işlemi
			string coverImageName = "";
			string bigImageName = "";
            if (model.BigImage != null && model.CoverImage != null)
			{
				string coverImageExtension = Path.GetExtension(model.CoverImage.FileName);
                string bigImageExtension = Path.GetExtension(model.BigImage.FileName);

				coverImageName = Guid.NewGuid() + coverImageExtension;
                bigImageName = Guid.NewGuid() + bigImageExtension;

				string coverImagePath = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/carbook-master/images/{coverImageName}");
                string bigImagePath = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/carbook-master/images/{bigImageName}");

				using var coverImageStream = new FileStream(coverImagePath, FileMode.Create);
                using var bigImageStream = new FileStream(bigImagePath, FileMode.Create);
				await model.CoverImage.CopyToAsync(coverImageStream);
				await model.BigImage.CopyToAsync(bigImageStream);
			}
			var carDto = new CreateCarDto
			{
				BrandId = model.BrandId,
				BigImageUrl = bigImageName,
				CoverImageUrl = coverImageName,
				Fuel = model.Fuel,
				Km = model.Km,
				Luggage = model.Luggage,
				Model = model.CarModel,
				Seat = model.Seat,
				Transmission = model.Transmission
			};
			var client = _httpClientFactory.CreateClient();
			var jsonDataForCar = JsonSerializer.Serialize(carDto);
			var stringContentForCar = new StringContent(jsonDataForCar, Encoding.UTF8, "application/json");
			var responseMessageForCar = await client.PostAsync("https://localhost:7060/api/Car", stringContentForCar);
			if (responseMessageForCar.IsSuccessStatusCode)
			{
				var carIdJsonData = await responseMessageForCar.Content.ReadAsStringAsync();
				var data = JsonSerializer.Deserialize<ResultCarIdDto>(carIdJsonData);


				var priceDto = new CreatePriceDto
				{
					AmountDay = model.AmountDay,
					AmountHour = model.AmountHour,
					AmountWeek = model.AmountWeek,
					CarId = data.carId
				};
				var jsonDataForPrice = JsonSerializer.Serialize(priceDto);
				var stringContentForPrice = new StringContent(jsonDataForPrice, Encoding.UTF8, "application/json");
				await client.PostAsync("https://localhost:7060/api/Pricing", stringContentForPrice);
            }

            return Redirect("/Admin/AdminCar/Index");
		}
	}
}
