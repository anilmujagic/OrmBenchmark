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
    
    public partial class Order042
    {
        public Order042()
        {
            this.OrderLine042 = new HashSet<OrderLine042>();
        }
    
        public int Order042ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer042ID { get; set; }
        public string Note { get; set; }
    
        public virtual Customer042 Customer042 { get; set; }
        public virtual ICollection<OrderLine042> OrderLine042 { get; set; }
    }
}
