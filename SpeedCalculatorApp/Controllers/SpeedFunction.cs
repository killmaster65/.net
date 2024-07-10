using Forms.Models;
using Microsoft.AspNetCore.Mvc;
namespace SpeedCalculatorApp.Controllers
{
    public class SpeedFunction : Controller
    {
        private readonly ILogger<SpeedFunction> _logger;
        private readonly ConversionModelDbContext _context;

        public SpeedFunction(ILogger<SpeedFunction> logger, ConversionModelDbContext context)
        {
            _logger = logger;
            _context = context; 
        }
    public IActionResult Result(ConversionModel problem)
    {
            if (problem.Time == 0)
            {
                ViewBag.Error = "Time cannot be zero.";
                return View("Speed");
            }

            problem.ConvertTime();
            problem.ConvertDistance();
            problem.CalculateSpeed();
            UpdateDb(problem);

            return View("Result", problem);
        }

        public IActionResult Dis(ConversionModel problem)
        {
            problem.ConvertTime();
            problem.ConvertSpeed();
            problem.CalculateDis();
            UpdateDb(problem);

            return View("Dis", problem);
            
        }
        public IActionResult Time(ConversionModel problem)
        {
            
            problem.ConvertDistance();
            problem.ConvertSpeed();
            problem.CalculateTime();
            UpdateDb(problem);


            return View("Time",problem);
            
        }
        public void UpdateDb(ConversionModel problem)
        {
            _context.ConversionModels.Add(problem);
            _logger.LogInformation("Added problem to context");
            _context.SaveChanges();
            _logger.LogInformation("Saved changes to context");
        }
    }
}

