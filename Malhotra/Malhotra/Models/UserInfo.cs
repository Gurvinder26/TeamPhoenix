using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Malhotra.Models
{
    public class UserInfo
    {

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string UserEmail { get; set; }

        [Required]
        [Display(Name = "Phone")]
        public string UserPhoneNo { get; set; }

        [Required]
        [Display(Name = "Address 1")]
        public string UserAddress1 { get; set; }

        [Display(Name = "Address 2")]
        public string UserAddress2 { get; set; }

        [Required]
        [Display(Name = "City")]
        public string UserCity { get; set; }

        [Required]
        [Display(Name = "Province")]
        public string UserProvince { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        public string UserPostal { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}