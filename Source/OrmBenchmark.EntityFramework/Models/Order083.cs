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
    
    public partial class Order083
    {
        public Order083()
        {
            this.OrderLine083 = new HashSet<OrderLine083>();
        }
    
        public int Order083ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer083ID { get; set; }
        public string Note { get; set; }
    
        public virtual Customer083 Customer083 { get; set; }
        public virtual ICollection<OrderLine083> OrderLine083 { get; set; }
    }
}
