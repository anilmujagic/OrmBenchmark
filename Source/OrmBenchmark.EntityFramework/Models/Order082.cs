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
    
    public partial class Order082
    {
        public Order082()
        {
            this.OrderLine082 = new HashSet<OrderLine082>();
        }
    
        public int Order082ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer082ID { get; set; }
        public string Note { get; set; }
    
        public virtual Customer082 Customer082 { get; set; }
        public virtual ICollection<OrderLine082> OrderLine082 { get; set; }
    }
}
