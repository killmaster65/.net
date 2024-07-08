using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

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
            if (TimeUnit == "minutes")
            {
                Time *= 60;
            }
            else if (TimeUnit == "hours")
            {
                Time *= 3600;
            }
            else if (TimeUnit == "seconds")
            {
                Time *= 1;
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
            DisUnit = "meters";
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
            Time = Distance / Speed;
        }
    }

    // Define the DbContext
    public class ConversionModelDbContext : DbContext
    {
        public DbSet<ConversionModel> ConversionModels { get; set; }

        public ConversionModelDbContext(DbContextOptions<ConversionModelDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("YourConnectionString");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConversionModel>(entity =>
            {
                entity.HasKey(e => e.ProblemID);
                entity.Property(e => e.TimeUnit).IsRequired();
                entity.Property(e => e.DisUnit).IsRequired();
                entity.Property(e => e.SpeedUnit).IsRequired();
            });
        }
    }

    // Example service or repository class that interacts with the DbContext
    public class ConversionService
    {
        private readonly ConversionModelDbContext _context;

        public ConversionService(ConversionModelDbContext context)
        {
            _context = context;
        }

        public List<ConversionModel> GetAllProblems()
        {
            return _context.ConversionModels.ToList();
        }
    }

}
