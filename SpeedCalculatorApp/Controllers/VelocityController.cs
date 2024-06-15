using Microsoft.AspNetCore.Mvc;

namespace SpeedCalculatorApp.Controllers
{
    public class VelocityFunction : Controller
    {
        [HttpPost]
        public IActionResult VelocityResults(VelocityProblem problem)
        {
            if (ModelState.IsValid) // Check for valid data
        {
            problem.Speed = problem.Distance / problem.Time; // Calculate speed
            return View("Result", problem); // Pass model to result view
        }
        return View("Velocity"); // Redirect back to page on error
        }

    }
}
