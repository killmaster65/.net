using Forms.Models;
using Microsoft.AspNetCore.Mvc;

namespace SpeedCalculatorApp.Controllers
{
    public class SpeedFunction : Controller
    {
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

            return View("Result", problem);
        }

        public IActionResult Dis(ConversionModel problem)
        {
            problem.ConvertTime();
            problem.ConvertSpeed();
            problem.CalculateDis();

            return View("Dis", problem);
            
        }
        public IActionResult Time(ConversionModel problem)
        {
            problem.ConvertDistance();
            problem.ConvertSpeed();
            problem.CalculateTime();
            


            return View("Time",problem);
            
        }
    }
}

