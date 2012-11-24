using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order001
    {
        public Order001()
        {
            this.OrderLine001 = new List<OrderLine001>();
        }

        public int Order001ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer001ID { get; set; }
        public string Note { get; set; }
        public virtual Customer001 Customer001 { get; set; }
        public virtual ICollection<OrderLine001> OrderLine001 { get; set; }
    }
}
