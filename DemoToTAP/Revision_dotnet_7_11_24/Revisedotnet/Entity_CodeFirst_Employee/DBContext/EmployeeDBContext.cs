using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.EntityFramework;
using System.Data.Entity;
using MySql.Data;
using Entity_CodeFirst_Employee.Models;
using System.Data;


namespace Entity_CodeFirst_Employee
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public string conString = @"server=loacalhost;port=3306;user=root;password=password;databse=sampleDatabse";

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(conString);
        }*/
    }
}