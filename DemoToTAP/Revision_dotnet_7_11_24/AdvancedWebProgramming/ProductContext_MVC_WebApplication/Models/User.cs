﻿using System.ComponentModel.DataAnnotations;

namespace ProductContext_MVC_WebApplication.Models
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
