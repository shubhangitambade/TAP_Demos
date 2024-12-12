using EFCodeFirst_Student.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCodeFirst_Student.Data
{
    public class StudentDBContext:DbContext
    {
        public StudentDBContext(DbContextOptions dbContextOptions):base(dbContextOptions) { }

        private string ConString = @"server=localhost;port=3306;user=root;password=password;database=sampledatabase";
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql(ConString, ServerVersion.AutoDetect(ConString));
        }


    }
}
