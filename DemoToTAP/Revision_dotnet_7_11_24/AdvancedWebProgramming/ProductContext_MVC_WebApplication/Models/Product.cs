using System.ComponentModel.DataAnnotations;

namespace ProductContext_MVC_WebApplication.Models
{
    public class Product
    {

        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        //egularExpression(@"^\$?d+(\.(d{2}))?$")]

        public double UnitPrice { get; set; } = 0;
        [Required]
        [Range(minimum: 1, maximum: 100)]
        public int Quantity { get; set; }

        public DateTime ExpiryDate { get; set; }
    }
}
