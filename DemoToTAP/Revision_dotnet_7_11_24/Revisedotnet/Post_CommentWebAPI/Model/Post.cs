namespace Post_CommentWebAPI.Model
{
    public class Post
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int? UserId { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public Post post{ get; set; }
        public User User { get; set; }
    }
}
