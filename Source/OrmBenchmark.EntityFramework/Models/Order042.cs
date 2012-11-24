using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order042
    {
        public Order042()
        {
            this.OrderLine042 = new List<OrderLine042>();
        }

        public int Order042ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer042ID { get; set; }
        public string Note { get; set; }
        public virtual Customer042 Customer042 { get; set; }
        public virtual ICollection<OrderLine042> OrderLine042 { get; set; }
    }
}
