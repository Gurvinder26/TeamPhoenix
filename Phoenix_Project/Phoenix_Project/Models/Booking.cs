using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Phoenix_Project.Models
{
    public class Booking
    {

      [Display(Name = "FirstName")]
      [Required]
      public string FirstName { get; set; }


        [Display(Name = "LastName")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Phone")]
        [Required]
        public string PhoneNo { get; set; }

        
        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }

        
        [Display(Name = "Address 1")]
        [Required]
        public string Address1 { get; set; }

        [Display(Name = "Address 2")]
        public string Address2 { get; set; }

       
        [Display(Name = "City")]
        [Required]
        public string City { get; set; }

         [Display(Name = "Province")]
         [Required] 
        public string Province { get; set; }
       
        [Display(Name = "Postal Code")]
        [Required]
        public string Postal { get; set; }

       
        [Display(Name = "Event Type")]
        [Required]
        public string EventType { get; set; }

        
        [Display(Name = "Description about the Event")]
        [Required]
        public string Description { get; set; }

       
        [Display(Name = "Preferred date of contact 1")]
        [DisplayFormat(DataFormatString = "{0:MM/DD/YYYY}")]
        [Required]
        public DateTime PrefferredDateOFContact1 { get; set; }

       
        [Display(Name = "Preferred date of contact 2")]
        [DisplayFormat(DataFormatString = "{0:MM/DD/YYYY}")]
        [Required]
        public DateTime PrefferredDateOFContact2 { get; set; }
    }
}