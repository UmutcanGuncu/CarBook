using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarBook.WebUI.Models;

namespace CarBook.WebUI.Controllers;

public class HomeController : Controller
{ 

    public IActionResult Index()
    {
        ViewBag.ControllerName = "Anasayfa";
        ViewBag.PageTitle = "Anasayfa";
        return View();
    }
}

