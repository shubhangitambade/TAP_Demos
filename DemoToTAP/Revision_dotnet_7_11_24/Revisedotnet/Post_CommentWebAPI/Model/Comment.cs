namespace Post_CommentWebAPI.Model
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
