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
    
    public partial class Customer066
    {
        public Customer066()
        {
            this.Order066 = new HashSet<Order066>();
        }
    
        public string Customer066ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    
        public virtual ICollection<Order066> Order066 { get; set; }
    }
}
