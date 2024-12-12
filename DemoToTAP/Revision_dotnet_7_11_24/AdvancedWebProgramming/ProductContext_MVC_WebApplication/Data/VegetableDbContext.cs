using Microsoft.EntityFrameworkCore;
using ProductContext_MVC_WebApplication.Models;

namespace ProductContext_MVC_WebApplication.Data
{
    public class VegetableDbContext:DbContext
    {
        public VegetableDbContext(DbContextOptions<VegetableDbContext> options) : base(options) { }

        private string ConString = @"server=localhost;port=3306;user=root;password=password;database=sampledatabase";
        public DbSet<Product> vegetables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql(ConString, ServerVersion.AutoDetect(ConString));
        }
    }
}
