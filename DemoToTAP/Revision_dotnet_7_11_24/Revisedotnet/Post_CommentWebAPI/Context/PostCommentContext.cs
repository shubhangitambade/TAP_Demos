using Microsoft.EntityFrameworkCore;
using Post_CommentWebAPI.Model;

namespace Post_CommentWebAPI.Context
{
    public class PostCommentContext:DbContext
    {
        public PostCommentContext(DbContextOptions options) : base(options){ }

        string ConString = @"server=localhost;port=3306;user=root;password=password;database=sampledatabase";
        
        DbSet<User> user{get;set;}
        DbSet<Comment> comments { get;set;}
        DbSet<Post> posts { get;set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           //ase.OnConfiguring(optionsBuilder);
           optionsBuilder.UseMySQL(ConString);
        }

    }
}
