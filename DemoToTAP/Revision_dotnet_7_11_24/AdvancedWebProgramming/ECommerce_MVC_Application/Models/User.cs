using System.ComponentModel.DataAnnotations;

namespace ECommerce_MVC_Application.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]

        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
