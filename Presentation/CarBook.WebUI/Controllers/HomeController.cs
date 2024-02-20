using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarBook.WebUI.Models;

namespace CarBook.WebUI.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}

