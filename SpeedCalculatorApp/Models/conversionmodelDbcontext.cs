using Forms.Models;
using Microsoft.EntityFrameworkCore;

namespace conversionmodel.Models{

    public class ConversionmodelDbcontext : DbContext
    {

        public DbSet<ConversionModel> ConversionModel { get; set; }
        public ConversionmodelDbcontext(DbContextOptions<ConversionmodelDbcontext> options)
            : base(options)
        {
            
        }
    }
}