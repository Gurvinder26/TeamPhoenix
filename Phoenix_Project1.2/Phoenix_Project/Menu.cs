//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Phoenix_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Menu
    {
        public Menu()
        {
            this.MenuItems = new HashSet<MenuItem>();
            this.Products = new HashSet<Product>();
        }
    
        public int Id { get; set; }
        public string MenuProduct { get; set; }
        public string MenuType { get; set; }
    
        public virtual ICollection<MenuItem> MenuItems { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
