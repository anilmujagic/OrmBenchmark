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
    
    public partial class Order057
    {
        public Order057()
        {
            this.OrderLine057 = new HashSet<OrderLine057>();
        }
    
        public int Order057ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer057ID { get; set; }
        public string Note { get; set; }
    
        public virtual Customer057 Customer057 { get; set; }
        public virtual ICollection<OrderLine057> OrderLine057 { get; set; }
    }
}
