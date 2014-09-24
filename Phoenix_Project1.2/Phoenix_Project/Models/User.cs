using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Phoenix_Project.Models
{
     [MetadataType(typeof(User))]
    public class User
    {

        [Required]
        [Display(Name = "User Name")]
        [DataType(DataType.Text)]
        public string UserName{ get; set; }

        [Required]
        [Display(Name = "FirstName")]
        [DataType(DataType.Text)]
        public string FirstName{ get; set; }

        [Required]
        [Display(Name = "LastName")]
        [DataType(DataType.Text)]
        public string LastName{ get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string UserEmail{ get; set; }

        [Required]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string UserPhoneNo{ get; set; }

        [Required]
        [Display(Name = "Address 1")]
        [DataType(DataType.Text)]
        public string UserAddress1{ get; set; }

        [Display(Name = "Address 2")]
        [DataType(DataType.Text)]
        public string UserAddress2{ get; set; }

        [Required]
        [Display(Name = "City")]
        [DataType(DataType.Text)]
        public string UserCity{ get; set; }

        [Required]
        [Display(Name = "Province")]
        [DataType(DataType.Text)]
        public string UserProvince{ get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        [DataType(DataType.PostalCode)]
        public string UserPostal{ get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Text)]
        public string Password{ get; set; }
    }
}