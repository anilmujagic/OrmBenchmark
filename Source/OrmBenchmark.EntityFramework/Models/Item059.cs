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
    
    public partial class Item059
    {
        public Item059()
        {
            this.OrderLine059 = new HashSet<OrderLine059>();
        }
    
        public string Item059ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    
        public virtual ICollection<OrderLine059> OrderLine059 { get; set; }
    }
}
