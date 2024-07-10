using Microsoft.EntityFrameworkCore;

namespace Forms.Models
{
    // Define the model
    public class ConversionModel
    {
        public int ProblemID { get; set; }
        public double Distance { get; set; }
        public double Time { get; set; }
        public string TimeUnit { get; set; } = string.Empty;
        public string DisUnit { get; set; } = string.Empty;
        public double Speed { get; set; }
        public string SpeedUnit { get; set; } = string.Empty;

        public void ConvertTime()
        {
            if (TimeUnit == "Minutes")
            {
                Time *= 60;
            }
            else if (TimeUnit == "Hours")
            {
                Time *= 3600;
            }
            else if (TimeUnit == "Seconds")
            {
                Time *= 1;
            }
            TimeUnit = "Seconds";
        }

        public void ConvertDistance()
        {
            if (DisUnit == "Meters")
            {
                Distance *= 1;
            }
            else if (DisUnit == "Centimeter")
            {
                Distance /= 100;
            }
            else if (DisUnit == "Millimeter")
            {
                Distance /= 1000;
            }
            else if (DisUnit == "Kilometer")
            {
                Distance *= 1000;
            }
            DisUnit = "Meters";
        }

        public void ConvertSpeed()
        {
            if (SpeedUnit == "Meters per second")
            {
                Speed *= 1;
            }
            else if (SpeedUnit == "Kilometers per hour")
            {
                Speed *= 0.277778; // 1 km/h = 0.277778 m/s
            }
            else if (SpeedUnit == "Miles per hour")
            {
                Speed *= 0.44704; // 1 mph = 0.44704 m/s
            }
            else if (SpeedUnit == "Feet per second")
            {
                Speed *= 0.3048; // 1 ft/s = 0.3048 m/s
            }
            SpeedUnit = "Meters per Seconds";
        
        }

        public void CalculateSpeed()
        {
            Speed = Distance / Time;
            SpeedUnit = "Meters per Seconds";
        }

        public void CalculateDis()
        {
            Distance = Speed * Time;
            DisUnit = "Meters";
        }

        public void CalculateTime()
        {
            Time = Distance / Speed;
            TimeUnit = "Seconds";
        }
    }
}

