using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order032
    {
        public Order032()
        {
            this.OrderLine032 = new List<OrderLine032>();
        }

        public int Order032ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer032ID { get; set; }
        public string Note { get; set; }
        public virtual Customer032 Customer032 { get; set; }
        public virtual ICollection<OrderLine032> OrderLine032 { get; set; }
    }
}
