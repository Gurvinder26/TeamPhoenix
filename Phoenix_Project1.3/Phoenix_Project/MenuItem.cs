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
    
    public partial class MenuItem
    {
        public MenuItem()
        {
            this.Menus = new HashSet<Menu>();
            this.PlacedOrderItems = new HashSet<PlacedOrderItem>();
        }
    
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        public double ItemPrice { get; set; }
        public string image { get; set; }
        public string Category { get; set; }
    
        public virtual ICollection<Menu> Menus { get; set; }
        public virtual ICollection<PlacedOrderItem> PlacedOrderItems { get; set; }
    }
}