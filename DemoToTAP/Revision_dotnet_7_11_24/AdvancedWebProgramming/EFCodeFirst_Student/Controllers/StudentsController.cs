using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EFCodeFirst_Student.Data;
using EFCodeFirst_Student.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCodeFirst_Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentDBContext _dbContext;

        public StudentsController(StudentDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]

        public async Task<IActionResult> AddStudent(Student student)
        {
            if (student == null)
            {
                return BadRequest();
            }
            else
            {
                _dbContext.Students.Add(student);
                _dbContext.SaveChangesAsync();
                return Ok(student);
            }
        }

        [HttpGet]

        public async Task<IActionResult> GetAllStudents()
        {
            List<Student> students = await _dbContext.Students.ToListAsync();
            return Ok(students);

        }
    }
}
