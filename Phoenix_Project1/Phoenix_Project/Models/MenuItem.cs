using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Phoenix_Project.Models
{
    public class MenuItem
    {
        public int Id { get; set; }

        [Required]
        public String ItemName { get; set; }
        [Required]
        public String ItemDesc { get; set; }
        [Required]
        public float ItemPrice { get; set; }

        public String image { get; set; }
        [Required]
        public String Category { get; set; }
    }
}