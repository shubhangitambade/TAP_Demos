using Microsoft.EntityFrameworkCore;
using Code_First_Approach_EF.Models;



namespace Code_First_Approach_EF
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Users> Users { get; set; }

       /* public string conString = @"server=localhost;port=3306;user=root;password=password;database=sampledatabase";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(conString);
        }
       */
    }
}
