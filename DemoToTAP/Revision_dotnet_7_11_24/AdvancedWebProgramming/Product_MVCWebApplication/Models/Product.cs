﻿using System.ComponentModel.DataAnnotations;

namespace Product_MVCWebApplication.Models
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

        public decimal UnitPrice { get; set; } = 0;
        [Required]
        [Range(minimum:10,maximum:5000)]
        public int Quantity { get;set; }

        public DateTime ExpiryDate{ get; set; }
    }
}
