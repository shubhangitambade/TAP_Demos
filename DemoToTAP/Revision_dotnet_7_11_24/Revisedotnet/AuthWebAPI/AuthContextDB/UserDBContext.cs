using Microsoft.EntityFrameworkCore;
using AuthWebAPI.Model;

namespace AuthWebAPI.AuthContextDB
{
    public class UserDBContext :DbContext
    {
        public DbSet<User> Users { get; set; }

        public string ConString = @"server=localhost;port=3306;user=root;password=password;databse=SampleDatabase";
       
        public DbSet<User> user{ get;set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(ConString);
        }
    }
}
