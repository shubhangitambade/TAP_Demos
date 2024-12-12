using EFCodeFirst_PostComment.Data;
using EFCodeFirst_PostComment.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCodeFirst_PostComment.Data
{
    public class PostCommentDBContext : DbContext
    {
        public PostCommentDBContext(DbContextOptions dbContextOptions):base(dbContextOptions) { }

        DbSet<User> people { get;set; }
        DbSet<Post> posts { get;set; }
        DbSet<Comment> comments { get;set; }

    }
}
