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
    
    public partial class Item036
    {
        public Item036()
        {
            this.OrderLine036 = new HashSet<OrderLine036>();
        }
    
        public string Item036ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    
        public virtual ICollection<OrderLine036> OrderLine036 { get; set; }
    }
}
