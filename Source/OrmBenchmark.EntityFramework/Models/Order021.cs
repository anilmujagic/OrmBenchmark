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
    
    public partial class Order021
    {
        public Order021()
        {
            this.OrderLine021 = new HashSet<OrderLine021>();
        }
    
        public int Order021ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer021ID { get; set; }
        public string Note { get; set; }
    
        public virtual Customer021 Customer021 { get; set; }
        public virtual ICollection<OrderLine021> OrderLine021 { get; set; }
    }
}
