using Microsoft.EntityFrameworkCore;
using EfCodeFirst_MySql.Models;

namespace EfCodeFirst_MySql.Data
{
    public class AppDbContext:DbContext
    {
        
        public AppDbContext(DbContextOptions options) : base(options) { }

        //private string ConString = @"server=localhost;port=3306;user=root;password=password;database=sampledatabase";
        public DbSet<Product> products { get;set; }

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql(ConString, ServerVersion.AutoDetect(ConString));
                
        }*/

    }
}
