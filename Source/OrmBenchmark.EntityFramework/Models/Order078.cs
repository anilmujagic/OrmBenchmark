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
    
    public partial class Order078
    {
        public Order078()
        {
            this.OrderLine078 = new HashSet<OrderLine078>();
        }
    
        public int Order078ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer078ID { get; set; }
        public string Note { get; set; }
    
        public virtual Customer078 Customer078 { get; set; }
        public virtual ICollection<OrderLine078> OrderLine078 { get; set; }
    }
}
