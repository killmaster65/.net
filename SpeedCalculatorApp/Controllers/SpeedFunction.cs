using Microsoft.AspNetCore.Mvc;

namespace SpeedCalculatorApp.Controllers
{
    public class SpeedFunction : Controller
    {
        //S
        public IActionResult Result(double time, double distance, string TimeUnit, string DisUnit)
        {
            if (time == 0)
            {
                ViewBag.Error = "Time cannot be zero.";
                return View("Speed");
            }
            if (TimeUnit == "Seconds" ){
                time *= 1;
            }
            if (TimeUnit == "minutes" ){
                time *= 60;
            }
            if (TimeUnit == "hours" ){
                time *= 3600;
            }

            if (DisUnit == "meters" ){
                distance *= 1;
            }
            if (DisUnit == "centimeter" ){
                distance /= 100;
            }
            if (DisUnit == "millimeter" ){
                distance /= 1000;
            }
            if (DisUnit == "kilometer" ){
                distance *= 1000;
            }
            double speed = distance/time;
            ViewBag.Speed = speed;
            
            return View("Result");
            
        }

        public IActionResult Dis(double Speed, double Time, string TimeUnit)
        {
            //changing the unit for time into seconds
            if (TimeUnit == "Seconds" ){
                Time *= 1;
            }
            if (TimeUnit == "minutes" ){
                Time *= 60;
            }
            if (TimeUnit == "hours" ){
                Time *= 3600;
            }




            double distance = Speed * Time;
            ViewBag.Dis = distance;
            return View("Dis");
            
        }
        public IActionResult Time(double Speed, double Distance, string DisUnit)
        {
            if (DisUnit == "meters" ){
                Distance *= 1;
            }
            if (DisUnit == "centimeter" ){
                Distance /= 100;
            }
            if (DisUnit == "millimeter" ){
                Distance /= 1000;
            }
            if (DisUnit == "kilometer" ){
                Distance *= 1000;
            }


            double Time = Distance/Speed;
            ViewBag.Time = Time;
            return View("Time");
            
        }
    }
}
