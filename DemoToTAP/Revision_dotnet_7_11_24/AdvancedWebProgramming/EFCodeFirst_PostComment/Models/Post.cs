namespace EFCodeFirst_PostComment.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int? UserId { get; set; }
        public User user { get; set; }
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
