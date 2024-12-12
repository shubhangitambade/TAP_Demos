using StudentPortalWebAPI.Entities;
using StudentPortalWebAPI.Data;
using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace StudentPortalWebAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentPortalDbContext _studentPortalDb;
        public StudentService(StudentPortalDbContext studentPortalDb) {

            _studentPortalDb = studentPortalDb;
        }

        public async Task<List<Student>> getAllStudentsAsync()
        {
            var student = await _studentPortalDb.Student.Include(_ => _.Address).ToListAsync();
            Console.WriteLine(student);
            return student;
        }

        public async Task<Address> getAddressByStudentId(int id)
        {
            
            var address = await _studentPortalDb.Address.Include(_ => _.Student).Where(stu => stu.Id == id).FirstOrDefaultAsync();

            //var student = await _studentPortalDbContext.Student.Include(_ => _.Address).Where(_ => _.Id == id).FirstOrDefaultAsync();
            return address;
        }

        public async Task<Student> getAllStudentByIdAsync(int id)
        {
            var student = await _studentPortalDb.Student.Include(_ => _.Address).Where(_ => _.Id == id).FirstOrDefaultAsync();
            return student;
        }
    }
}
