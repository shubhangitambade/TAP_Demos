using System.ComponentModel.DataAnnotations;

namespace Product_MVC_HardcodeList.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
