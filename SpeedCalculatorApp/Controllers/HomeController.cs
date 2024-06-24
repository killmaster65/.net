using System.Diagnostics;
using Forms.Models;
using Microsoft.AspNetCore.Mvc;
using SpeedCalculatorApp.Models;

namespace SpeedCalculatorApp.Controllers;

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

    public IActionResult Speed()
    {
        return View();
    }
    public IActionResult Result(ConversionModel problem)
    {
        return View();
    }
    public IActionResult Dis(ConversionModel problem)
    {
        return View();
    }
    public IActionResult Time(ConversionModel problem)
    {
        return View();
    }
    public IActionResult KenticEnergy()
    {
        return View();
    }
    public IActionResult KEResult()
    {
        return View();
    }




    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
