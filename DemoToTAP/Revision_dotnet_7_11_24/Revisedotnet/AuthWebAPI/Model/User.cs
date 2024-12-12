using System.ComponentModel.DataAnnotations;

namespace AuthWebAPI.Model
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
