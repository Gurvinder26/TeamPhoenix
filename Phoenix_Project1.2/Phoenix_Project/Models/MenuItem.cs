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
      [DataType(DataType.Text)]
        public string ItemName { get; set; }
        [Required]
        public string ItemDesc { get; set; }
        [Required]
        public float ItemPrice { get; set; }

        public string image { get; set; }
        [Required]
        public string Category { get; set; }
    }
}