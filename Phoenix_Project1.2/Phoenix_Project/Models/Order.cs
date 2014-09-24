using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Phoenix_Project.Models
{
    public class Order
    {
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Description of the product")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Product Quantity")]
        public float ProductQty { get; set; }
        [Required]
        [Display(Name = "Total Price")]
        public float TotalPrice { get; set; }
    }
}