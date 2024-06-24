using Microsoft.AspNetCore.Mvc;

namespace SpeedCalculatorApp.Controllers
{
    public class KEFunction : Controller
    {
         public IActionResult KEResult(double mass, double velocity)
        {
            double V = Math.Pow(velocity,2);
            double KenticEnergy = mass*V/2;
            ViewBag.KE = KenticEnergy;
            return View();
        }
    }
}
