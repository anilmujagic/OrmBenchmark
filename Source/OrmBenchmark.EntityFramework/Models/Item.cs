//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrmBenchmark.EntityFramework.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public Item()
        {
            this.Discounts = new HashSet<Discount>();
            this.OrderLines = new HashSet<OrderLine>();
        }
    
        public string ItemID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    
        public virtual ICollection<Discount> Discounts { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
