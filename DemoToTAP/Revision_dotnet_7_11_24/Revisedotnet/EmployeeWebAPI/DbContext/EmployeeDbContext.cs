using MySql.Data;
using MySql.EntityFrameworkCore;
using EmployeeWebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebAPI
{
    public class EmployeeDbContext: DbContext
    {
        public DbSet<Employee> Employees{ get; set; }

        public string conString = @"server=localhost;port=3306;user=root;password=password;database=sampledatabase";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(conString);
        }
    }
}
