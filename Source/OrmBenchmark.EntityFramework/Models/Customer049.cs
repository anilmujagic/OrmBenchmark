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
    
    public partial class Customer049
    {
        public Customer049()
        {
            this.Order049 = new HashSet<Order049>();
        }
    
        public string Customer049ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    
        public virtual ICollection<Order049> Order049 { get; set; }
    }
}
