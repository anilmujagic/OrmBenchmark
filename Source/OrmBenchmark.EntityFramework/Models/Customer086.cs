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
    
    public partial class Customer086
    {
        public Customer086()
        {
            this.Order086 = new HashSet<Order086>();
        }
    
        public string Customer086ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    
        public virtual ICollection<Order086> Order086 { get; set; }
    }
}
