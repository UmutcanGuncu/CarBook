using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using CarBook.Application.Dtos.BlogDtos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarBook.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task <IActionResult> Index()
        {
            ViewBag.ControllerName = "Blog";
            ViewBag.PageTitle = "Blogumuz";
            var client =  _httpClientFactory.CreateClient();
            var repsonseMessage = await client.GetAsync("https://localhost:7060/api/Blog/blogListWithActorAndCategory");
            if (repsonseMessage.IsSuccessStatusCode)
            {
                var jsonData = await repsonseMessage.Content.ReadAsStringAsync();
                var values = JsonSerializer.Deserialize<List<ResultBlogWithCategoryAndAuthorDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> BlogDetail(Guid id)
        {
            ViewBag.ControllerName = "Blog";
            ViewBag.PageTitle = "Blog Detayları";
            return View();
        }
    }
}

