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
    
    public partial class Order072
    {
        public Order072()
        {
            this.OrderLine072 = new HashSet<OrderLine072>();
        }
    
        public int Order072ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer072ID { get; set; }
        public string Note { get; set; }
    
        public virtual Customer072 Customer072 { get; set; }
        public virtual ICollection<OrderLine072> OrderLine072 { get; set; }
    }
}
