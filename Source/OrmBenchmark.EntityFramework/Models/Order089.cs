using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order089
    {
        public Order089()
        {
            this.OrderLine089 = new List<OrderLine089>();
        }

        public int Order089ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer089ID { get; set; }
        public string Note { get; set; }
        public virtual Customer089 Customer089 { get; set; }
        public virtual ICollection<OrderLine089> OrderLine089 { get; set; }
    }
}
