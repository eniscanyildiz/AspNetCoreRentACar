using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RentACar.Business.Services;
using RentACar.Web.Models;

namespace RentACar.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ICarService _carService;

    public HomeController(ILogger<HomeController> logger, ICarService carManager)
    {
        _logger = logger;
        _carService = carManager;
    }

    public async Task<IActionResult> Index()
    {
        var cars = await _carService.GetAllCarsWithBrandAsync();
        return View(cars);
    }


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

