﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Product_MVC_Project.Models
{
    
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
