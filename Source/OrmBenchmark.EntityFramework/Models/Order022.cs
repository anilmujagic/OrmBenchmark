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
    
    public partial class Order022
    {
        public Order022()
        {
            this.OrderLine022 = new HashSet<OrderLine022>();
        }
    
        public int Order022ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer022ID { get; set; }
        public string Note { get; set; }
    
        public virtual Customer022 Customer022 { get; set; }
        public virtual ICollection<OrderLine022> OrderLine022 { get; set; }
    }
}
