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
    
    public partial class Order032
    {
        public Order032()
        {
            this.OrderLine032 = new HashSet<OrderLine032>();
        }
    
        public int Order032ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer032ID { get; set; }
        public string Note { get; set; }
    
        public virtual Customer032 Customer032 { get; set; }
        public virtual ICollection<OrderLine032> OrderLine032 { get; set; }
    }
}
