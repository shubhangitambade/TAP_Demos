using Microsoft.EntityFrameworkCore;
using EmployeDbContext.Repository;
using EmployeDbContext.Models;
using EmployeDbContext.DbContex;
using System.Data.SqlTypes;
using MySql.EntityFrameworkCore;

namespace EmployeDbContext.Repository
{
    public class EmployeeRepo
    {
        private EmployeeDBContext dbContext;
        public EmployeeRepo(EmployeeDBContext _dbContext) { 
            dbContext = _dbContext; //Dependency Injection
        }

        public List<Employee> GetAll() { 
        
            List<Employee> emps = dbContext.Employees.ToList();
            return emps;
        }

        public Employee Get(int id)
        {
            //Employee Emp = dbContext.Employees.Find(id);

            Employee employee = dbContext.Employees.SingleOrDefault(emp => emp.Id == id);
            return employee;
        }

        public bool Delete(int id)
        {
            bool status = false;
            Employee employee = dbContext.Employees.SingleOrDefault(emp=>emp.Id==id);
            if(employee != null)
            {
                dbContext.Employees.Remove(employee);
                dbContext.SaveChanges();
                status = true;

            }
            return status;
        }

        public bool Add(Employee employee)
        {
            bool status = false;
            dbContext.Add(employee);
            dbContext.SaveChanges ();
            status = true;

            return status;
        }

        public bool Update(Employee employee)
        {
            bool status = false;
           
            dbContext.Employees.Update(employee);
             dbContext.SaveChanges();
              status = true;
            return status;
        }
    }
}
