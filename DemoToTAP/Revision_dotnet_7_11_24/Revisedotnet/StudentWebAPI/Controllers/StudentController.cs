using Microsoft.AspNetCore.Mvc;
using StudentPortalWebAPI.Services;


namespace StudentPortalWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService) {
            _studentService = studentService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> getStudents()
        {
            var student = await _studentService.getAllStudentsAsync();
            return Ok(student);

        }
        [HttpGet("address/{id}")]
        public async Task<IActionResult> getAddressByStudentId(int id)
        {
            var address = await _studentService.getAddressByStudentId(id);
            return Ok(address);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> getStudent(int id)
        {
            var student = await _studentService.getAllStudentByIdAsync(id);
            return Ok(student);

        }
    }
}
