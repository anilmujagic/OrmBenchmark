using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order065
    {
        public Order065()
        {
            this.OrderLine065 = new List<OrderLine065>();
        }

        public int Order065ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer065ID { get; set; }
        public string Note { get; set; }
        public virtual Customer065 Customer065 { get; set; }
        public virtual ICollection<OrderLine065> OrderLine065 { get; set; }
    }
}
