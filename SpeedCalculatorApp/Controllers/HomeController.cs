using System.Diagnostics;
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
    public IActionResult Velocity()
    {
        return View();
    }
    [HttpPost]
    public IActionResult VelocityResults(VelocityProblem problem)
    {
        if (ModelState.IsValid) // Check for valid data
    {
        problem.Speed = problem.Distance / problem.Time; // Calculate speed
        return View("VelocityResults", problem); // Pass model to result view
    }
    return View("Velocity"); // Redirect back to page on error
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
