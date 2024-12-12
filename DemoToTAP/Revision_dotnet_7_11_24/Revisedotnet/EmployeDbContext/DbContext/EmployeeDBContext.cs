using Microsoft.EntityFrameworkCore;
using EmployeDbContext.Models;
using MySql.Data;
//DatabaseFirst Approach
namespace EmployeDbContext.DbContex
{
    public class EmployeeDBContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public string conString = @"server=localhost;port=3306;user=root;password=password;database=sampledatabase";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(conString);
        }
    }
}
