using ProductContext_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductContext_WebAPI.Data
{
    public class GadgetsDbContext:DbContext
    {
       public GadgetsDbContext(DbContextOptions<GadgetsDbContext> options) : base(options) { }

        private string ConString = @"server=localhost;port=3306;user=root;password=password;database=sampledatabase";
        public DbSet<Product> Gadgets { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConString,ServerVersion.AutoDetect(ConString)); 
        }
    }
}
