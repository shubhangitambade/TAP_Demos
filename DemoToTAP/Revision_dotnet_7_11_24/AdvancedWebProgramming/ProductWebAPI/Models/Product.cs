
using System.ComponentModel.DataAnnotations;

namespace ProductWebAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        [Range(minimum:10,maximum:5000)]
        public int Quantity { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }

    }
}
