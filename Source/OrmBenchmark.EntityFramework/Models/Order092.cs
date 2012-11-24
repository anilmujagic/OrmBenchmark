using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order092
    {
        public Order092()
        {
            this.OrderLine092 = new List<OrderLine092>();
        }

        public int Order092ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer092ID { get; set; }
        public string Note { get; set; }
        public virtual Customer092 Customer092 { get; set; }
        public virtual ICollection<OrderLine092> OrderLine092 { get; set; }
    }
}
