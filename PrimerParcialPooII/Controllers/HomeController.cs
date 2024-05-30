using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrimerParcialPooII.Models;

namespace PrimerParcialPooII.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Store()
    {
        StoreModel store = new StoreModel();
        store.Location =" Monterrey";
        
        





        return View();
    }
    public IActionResult Employee()
    {
        return View();
    }

    public IActionResult Product()
    {
        return View();
    }

   
}
