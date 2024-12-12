using Microsoft.EntityFrameworkCore;
using ProductWebAPI.Models;

namespace ProductWebAPI.Data
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        private string ConString = @"server=localhost;port=3306;user=root;password=password;database=sampledatabase";
        public DbSet<Product> FlowersCatalog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConString,ServerVersion.AutoDetect(ConString));
        }

    }
}
