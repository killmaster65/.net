using Microsoft.AspNetCore.Mvc;

namespace SpeedCalculatorApp.Controllers
{
    public class SpeedFunction : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult calculateSpeed(double time, double distance)
        {
            if (time == 0)
            {
                ViewBag.Error = "Time cannot be zero.";
                return View("Index");
            }

            double speed = distance / time;
            ViewBag.Speed = speed;
            return View("Result");
        }
    }
}
