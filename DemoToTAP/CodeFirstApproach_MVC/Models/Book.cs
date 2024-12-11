namespace CodeFirstApproach_MVC.Models
{
    public class Book
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
