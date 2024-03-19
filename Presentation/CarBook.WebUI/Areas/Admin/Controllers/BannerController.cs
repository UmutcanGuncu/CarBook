using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CarBook.Application.Dtos.BannerDtos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BannerController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7060/api/Banner");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonSerializer.Deserialize<List<ResultBannerDto>>(jsonData);
                return View(values);
            }
            return View();
            
        }
        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7060/api/Banner/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonSerializer.Deserialize<UpdateBannerDto>(jsonData);
                return View(value);
            }
                return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateBannerDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonSerializer.Serialize(model);
            var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7060/api/Banner", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return Redirect("/Admin/Banner/Index");
            }
            return View();
        }
        
        public async Task<IActionResult> Delete(Guid id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7060/api/Banner/{id}");
            return Redirect("/Admin/Banner/Index");
        }
    }
}

