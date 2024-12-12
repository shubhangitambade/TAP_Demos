using System.ComponentModel.DataAnnotations;

namespace EmployeDbContext.Models
{
    public class User
    {
       
        [Required]
        public string Uname { get; set; }
        public string Password { get; set; }
    }
}
