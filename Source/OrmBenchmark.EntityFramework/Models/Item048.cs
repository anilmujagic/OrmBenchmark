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
    
    public partial class Item048
    {
        public Item048()
        {
            this.OrderLine048 = new HashSet<OrderLine048>();
        }
    
        public string Item048ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    
        public virtual ICollection<OrderLine048> OrderLine048 { get; set; }
    }
}
