using Microsoft.AspNetCore.Mvc;
using EmployeeWebAPI.Model;
using EmployeeWebAPI.Services;

namespace EmployeeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService empService) { 
            _employeeService = empService;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task <IEnumerable<Employee>> GetAll()
        {
            List<Employee> employees = new List<Employee>();
            employees = await _employeeService.GetEmployees(); //the await keyword provides a non-blocking way to start a task
            return employees;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task <Employee> Get(int id)
        {
            Employee employee = await _employeeService.GetEmployee(id);  //the await keyword provides a non-blocking way to start a task,then continue execution when that task completes. 
            return employee;
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task Post([FromBody] Employee employee)
        {
            await _employeeService.Add(employee); //the await keyword provides a non-blocking way to start a task,then continue execution when that task completes. 

        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public async Task Put(int id,Employee emp)
        {
            await _employeeService.Update(id,emp); //the await keyword provides a non-blocking way to start a task,then continue execution when that task completes. 
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _employeeService.Delete(id);   //the await keyword provides a non-blocking way to start a task,then continue execution when that task completes. 
        }
    }
}
