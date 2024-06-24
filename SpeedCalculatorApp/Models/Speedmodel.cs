namespace Forms.Models{


public class ConversionModel
{
    public double Distance { get; set; }
    public double Time { get; set; }
    public required string TimeUnit { get; set; }
    public required string DisUnit { get; set; }
    public double Speed { get; set; }
    public required string SpeedUnit { get; set; }

        public void ConvertTime()
    {
        if (TimeUnit == "minutes")
        {
            Time *= 60;
        }
        else if (TimeUnit == "hours")
        {
            Time *= 3600;
        }
        else if (TimeUnit =="seconds")
        {
            Time *=1;
        }
    }

    public void ConvertDistance()
    {
        if (DisUnit == "meters")
        {
            Distance *= 1;
        }
        else if (DisUnit == "centimeter")
        {
            Distance /= 100;
        }
        else if (DisUnit == "millimeter")
        {
            Distance /= 1000;
        }
        else if (DisUnit == "kilometer")
        {
            Distance *= 1000;
        }
    }
    public void ConvertSpeed()
    {
            if (SpeedUnit == "meters per second")
            {
                Speed *= 1;
            }
            else if (SpeedUnit == "kilometers per hour")
            {
                Speed *= 0.277778; // 1 km/h = 0.277778 m/s
            }
            else if (SpeedUnit == "miles per hour")
            {
                Speed *= 0.44704; // 1 mph = 0.44704 m/s
            }
            else if (SpeedUnit == "feet per second")
            {
                Speed *= 0.3048; // 1 ft/s = 0.3048 m/s
            }
    }
           

    public void CalculateSpeed()
    {
        Speed = Distance / Time;
    }
    public void CalculateDis()
    {
        Distance = Speed * Time;
    }
    public void CalculateTime()
    {
        Time = Distance/Speed;
    }
}

}
