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
    
    public partial class Order087
    {
        public Order087()
        {
            this.OrderLine087 = new HashSet<OrderLine087>();
        }
    
        public int Order087ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer087ID { get; set; }
        public string Note { get; set; }
    
        public virtual Customer087 Customer087 { get; set; }
        public virtual ICollection<OrderLine087> OrderLine087 { get; set; }
    }
}
