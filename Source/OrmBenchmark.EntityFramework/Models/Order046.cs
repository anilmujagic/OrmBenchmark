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
    
    public partial class Order046
    {
        public Order046()
        {
            this.OrderLine046 = new HashSet<OrderLine046>();
        }
    
        public int Order046ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer046ID { get; set; }
        public string Note { get; set; }
    
        public virtual Customer046 Customer046 { get; set; }
        public virtual ICollection<OrderLine046> OrderLine046 { get; set; }
    }
}
