using EmployeeWebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeDbContext _employeedbContext;
        public EmployeeService(EmployeeDbContext empDbContext) {
            
            _employeedbContext = empDbContext;
        }
        public async Task Add(Employee employee)
        {
             _employeedbContext.Employees.Add(employee);
            await _employeedbContext.SaveChangesAsync();//the await keyword provides a non-blocking way to start a task,
        }

        public async Task Delete(int id)
        {
           Employee emp = _employeedbContext.Employees.FirstOrDefault(x => x.Id == id);
            if (emp != null)
            {
                _employeedbContext.Employees.Remove(emp);
                await _employeedbContext.SaveChangesAsync();//the await keyword provides a non-blocking way to start a task
            }
           
        }

        public async Task<Employee> GetEmployee(int id)
        {
            Employee employee = await _employeedbContext.Employees.FirstOrDefaultAsync(emp => emp.Id == id); //the await keyword provides a non-blocking way to start a task
            return employee;
        }

        public async Task <List<Employee>> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees = await _employeedbContext.Employees.ToListAsync(); //the await keyword provides a non-blocking way to start a task

            return employees;

          
        }

        public async Task Update(int id,Employee employee)
        {
           
            if (employee != null)
            {
                _employeedbContext.Employees.Update(employee);
                await _employeedbContext.SaveChangesAsync(); //the await keyword provides a non-blocking way to start a task
            }
        }
    }
}
