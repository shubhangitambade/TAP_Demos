using Microsoft.EntityFrameworkCore;
using Product_MVCWebApplication.Models;

namespace Product_MVCWebApplication.Data
{
    public class ProductDbContext : DbContext

    {
        public ProductDbContext(DbContextOptions dbcontextOptions) : base(dbcontextOptions)
        {

        }
        private string ConString = @"server=localhost;port=3306;user=root;password=password;database=sampledatabase";
        public DbSet<Product> flowers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql(ConString,ServerVersion.AutoDetect(ConString));
        }
    }
}
