using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CarBook.Application.Dtos.BrandDtos;
using CarBook.Application.Dtos.PriceDtos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BrandController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task <IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7060/api/Brand");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonSerializer.Deserialize<List<ResultBrandDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateBrandDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonSerializer.Serialize(model);
            var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7060/api/Brand",stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return Redirect("/Admin/Brand/Index");
            }
            return View();
        }
        [HttpGet]
        public async Task <IActionResult> Update(Guid id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7060/api/Brand/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonSerializer.Deserialize<UpdateBrandDto>(jsonData);
                return View(value);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateBrandDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonSerializer.Serialize(model);
            var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7060/api/Brand", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return Redirect("/Admin/Brand/Index");
            }
            return View();

        }
        public async Task<IActionResult> GetListCarByBrandId(Guid id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7060/api/Pricing/pricingWithCarAndBrand/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonSerializer.Deserialize<List<ResultPriceWithCarAndBrandDto>>(jsonData);
                return View(values);
            }
            return View();
        }
     }
}

