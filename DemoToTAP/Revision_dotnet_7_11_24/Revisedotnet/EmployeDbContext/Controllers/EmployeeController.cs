using Microsoft.AspNetCore.Mvc;
using EmployeDbContext.Models;
using EmployeDbContext.DbContex;
using EmployeDbContext.Repository;
using Microsoft.AspNetCore.Authorization;

namespace EmployeDbContext.Controllers
{
    public class EmployeeController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            //It will call Distructor automatically
           
            using (EmployeeDBContext _dbcontext = new EmployeeDBContext())
            {
                EmployeeRepo repo = new EmployeeRepo(_dbcontext);

                List<Employee> employees = repo.GetAll();

                ViewData["allEmployees"] = employees;
            }
                
            return View();
        }

        public IActionResult Details(int id)
        {
            using (EmployeeDBContext _dbcontext = new EmployeeDBContext())
            {
                EmployeeRepo repo = new EmployeeRepo(_dbcontext);

                Employee employee = repo.Get(id);

                ViewData["singleEmployee"] = employee;
            }

            return View();
        }

        public IActionResult Delete(int id)
        {
            using (EmployeeDBContext _dbcontext = new EmployeeDBContext())
            {
                EmployeeRepo repo = new EmployeeRepo(_dbcontext);

                bool status = repo.Delete(id);
                Console.WriteLine(status);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            using(EmployeeDBContext _dbContext = new EmployeeDBContext())
            {
                EmployeeRepo repo = new EmployeeRepo(_dbContext);
                bool status = repo.Add(employee);
                Console.WriteLine(status);  
            }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (EmployeeDBContext _dbContext = new EmployeeDBContext())
            {
                EmployeeRepo repo = new EmployeeRepo(_dbContext);
                Employee emp = repo.Get(id);
                //ViewData["Emp"] = emp;
                return View(emp);
            }

        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            using (EmployeeDBContext _dbContext = new EmployeeDBContext())
            {
                EmployeeRepo repo = new EmployeeRepo(_dbContext);
                bool status = repo.Update(employee);
                Console.WriteLine(status);
            }
            return RedirectToAction("Index");
        }

    


        [HttpGet]
        public IActionResult Update(int id)
        {
            using (EmployeeDBContext _dbContext = new EmployeeDBContext())
            {
                EmployeeRepo repo = new EmployeeRepo(_dbContext);
                Employee emp = repo.Get(id);
                //ViewData["Emp"] = emp;
                return View(emp);
            }
            
        }

        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            using (EmployeeDBContext _dbContext = new EmployeeDBContext())
            {
                EmployeeRepo repo = new EmployeeRepo(_dbContext);
                bool status = repo.Update(employee);
                Console.WriteLine(status);
            }
            return RedirectToAction("Index");
        }

    }
}
