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
    
    public partial class Order092
    {
        public Order092()
        {
            this.OrderLine092 = new HashSet<OrderLine092>();
        }
    
        public int Order092ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer092ID { get; set; }
        public string Note { get; set; }
    
        public virtual Customer092 Customer092 { get; set; }
        public virtual ICollection<OrderLine092> OrderLine092 { get; set; }
    }
}
