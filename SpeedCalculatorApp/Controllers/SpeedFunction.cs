using Microsoft.AspNetCore.Mvc;

namespace SpeedCalculatorApp.Controllers
{
    public class SpeedFunction : Controller
    {
        
        public IActionResult Result(double time, double distance)
        {
            if (time == 0)
            {
                ViewBag.Error = "Time cannot be zero.";
                return View("Speed");
            }

            double speed = distance / time;
            ViewBag.Speed = speed;
            
            return View("Result");
            
        }

        public IActionResult Dis(double Speed, double Time){


            double distance = Speed * Time;
            ViewBag.Dis = distance;
            return View("Dis");
            
        }
    }
}
