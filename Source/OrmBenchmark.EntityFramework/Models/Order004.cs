using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order004
    {
        public Order004()
        {
            this.OrderLine004 = new List<OrderLine004>();
        }

        public int Order004ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer004ID { get; set; }
        public string Note { get; set; }
        public virtual Customer004 Customer004 { get; set; }
        public virtual ICollection<OrderLine004> OrderLine004 { get; set; }
    }
}
