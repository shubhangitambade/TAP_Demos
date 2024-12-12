using EmployeeMVCWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMVCWebApplication.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }
        private string ConString = @"server=localhost;port=3306;user=root;password=password;database=studentportal";
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql(ConString,ServerVersion.AutoDetect(ConString)); 
        }

    }
}
