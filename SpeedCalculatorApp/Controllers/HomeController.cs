using System.Diagnostics;
using Forms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace SpeedCalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ConversionModelDbContext _context;

        public HomeController(ILogger<HomeController> logger, ConversionModelDbContext context)
        {
            _logger = logger;
            _context = context; 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult History()
        {
            var allProblems = _context.ConversionModels.ToList();
            return View(allProblems);
        }

        public IActionResult Speed()
        {
            return View();
        }

        public IActionResult Result(ConversionModel problem)
        {
            return View(problem);
        }

        public IActionResult Dis(ConversionModel problem)
        {
            return View(problem);
        }

        public IActionResult Time(ConversionModel problem)
        {
            return View(problem);
        }

        public IActionResult KineticEnergy(ConversionModel problem)
        {
            return View(problem);
        }

        public IActionResult KEResult(ConversionModel problem)
        {
            return View(problem);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}



