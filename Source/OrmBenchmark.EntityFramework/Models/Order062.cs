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
    
    public partial class Order062
    {
        public Order062()
        {
            this.OrderLine062 = new HashSet<OrderLine062>();
        }
    
        public int Order062ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer062ID { get; set; }
        public string Note { get; set; }
    
        public virtual Customer062 Customer062 { get; set; }
        public virtual ICollection<OrderLine062> OrderLine062 { get; set; }
    }
}
