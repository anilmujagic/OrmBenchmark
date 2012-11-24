using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order086
    {
        public Order086()
        {
            this.OrderLine086 = new List<OrderLine086>();
        }

        public int Order086ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer086ID { get; set; }
        public string Note { get; set; }
        public virtual Customer086 Customer086 { get; set; }
        public virtual ICollection<OrderLine086> OrderLine086 { get; set; }
    }
}
