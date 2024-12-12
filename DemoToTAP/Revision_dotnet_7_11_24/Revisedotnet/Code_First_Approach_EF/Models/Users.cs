using System.ComponentModel.DataAnnotations;

namespace Code_First_Approach_EF.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string? Name { get; set; }

        public int Age { get; set; }
    }
}
