using Microsoft.EntityFrameworkCore;
using StudentPortalWebAPI.Entities;

namespace StudentPortalWebAPI.Data
{
    public class StudentPortalDbContext:DbContext
    {
        public StudentPortalDbContext(DbContextOptions<StudentPortalDbContext> options) : base(options) { }
        //Register the classes
        public DbSet<Student> Student { get; set; }
        public DbSet<Address> Address { get; set; }

    }
}
