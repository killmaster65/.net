using System.Diagnostics;
using conversionmodel.Models;
using Forms.Models;
using Microsoft.AspNetCore.Mvc;
using SpeedCalculatorApp.Models;

namespace SpeedCalculatorApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ConversionmodelDbcontext _context;

    public HomeController(ILogger<HomeController> logger, ConversionmodelDbcontext context)
    {
        _logger = logger;
        _context = context; 
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult history()
    {
        var allproblems = _context.ConversionModel.ToList();
        return View(allproblems);
    }

    public IActionResult Speed()
    {
        return View();
    }
    public IActionResult Result(ConversionModel problem)
    {
        UpdateDb(problem);
        return View();
    }
    public IActionResult Dis(ConversionModel problem)
    {
        UpdateDb(problem);
        return View();
    }
    public IActionResult Time(ConversionModel problem)
    {
        UpdateDb(problem);
        return View();
    }
    public IActionResult KenticEnergy(ConversionModel problem)
    {
        UpdateDb(problem);
        return View();
    }
    public IActionResult KEResult(ConversionModel problem)
    {
        UpdateDb(problem);
        return View();
    }




    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
public void UpdateDb(ConversionModel problem){
    _context.ConversionModel.Add(problem);
    _context.SaveChanges();
}

}


