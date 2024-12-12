using EmployeeWebAPI.Model;
using System.Runtime.CompilerServices;
namespace EmployeeWebAPI.Services
{
    public interface IEmployeeService
    {
        Task <List<Employee>> GetEmployees();
        Task <Employee> GetEmployee(int id);

        Task  Add(Employee employee);
        Task Update(int id,Employee employee);
        Task Delete(int id);
            
    }
}
