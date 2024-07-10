
using Microsoft.EntityFrameworkCore;

namespace Forms.Models{





public class ConversionModelDbContext : DbContext
    {
        public DbSet<ConversionModel> ConversionModels { get; set; }

        public ConversionModelDbContext(DbContextOptions<ConversionModelDbContext> options)
            : base(options)
        {
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
}