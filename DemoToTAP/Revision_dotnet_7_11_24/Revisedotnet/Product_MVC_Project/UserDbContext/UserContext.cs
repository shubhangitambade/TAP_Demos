
using Product_MVC_Project.Models;
using MySql.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Data;



namespace Product_MVC_Project.UserDbContext
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set;}

        public string conString = @"server=localhost;port=3306;user=root;password=password;databse=sampledatabase";

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(conString);
        }

        /*protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().ToTable(options =>
            {
                options.HasMany(prop => prop.CompaniesCreated).WithOne(prop => p.Creator)
                    .HasForeignKey(prop => prop.UserId)
                        .IsRequired();

                options.HasMany(prop => prop.CompaniesModified).WithOne(prop => p.Modifier)
                    .HasForeignKey(prop => prop.UserId)
                        .IsRequired();
            });

            builder.Entity<Role>().ToTable(options =>
            {
                options.HasMany(prop => prop.Users).WithOne(prop => p.Role)
                    .HasForeignKey(prop => prop.RoleId)
                        .IsRequired();
            });
        }*/

    }
}
