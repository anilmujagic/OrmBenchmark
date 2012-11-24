using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order064
    {
        public Order064()
        {
            this.OrderLine064 = new List<OrderLine064>();
        }

        public int Order064ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer064ID { get; set; }
        public string Note { get; set; }
        public virtual Customer064 Customer064 { get; set; }
        public virtual ICollection<OrderLine064> OrderLine064 { get; set; }
    }
}
