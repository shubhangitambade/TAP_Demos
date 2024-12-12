using Employee_MVC_WebApplication.Models;

using Microsoft.EntityFrameworkCore;

namespace Employee_MVC_WebApplication.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions dbcontextoptions) : base(dbcontextoptions) { }

        private string ConString = @"server=localhost;port=3306;user=root;password=password;databse=schoolportal";
        public DbSet<Employee> employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql(ConString,ServerVersion.AutoDetect(ConString));
        }
    }
}
