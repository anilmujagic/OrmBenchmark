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
    
    public partial class Order088
    {
        public Order088()
        {
            this.OrderLine088 = new HashSet<OrderLine088>();
        }
    
        public int Order088ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer088ID { get; set; }
        public string Note { get; set; }
    
        public virtual Customer088 Customer088 { get; set; }
        public virtual ICollection<OrderLine088> OrderLine088 { get; set; }
    }
}
