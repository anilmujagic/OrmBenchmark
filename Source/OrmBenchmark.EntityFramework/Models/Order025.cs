using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order025
    {
        public Order025()
        {
            this.OrderLine025 = new List<OrderLine025>();
        }

        public int Order025ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer025ID { get; set; }
        public string Note { get; set; }
        public virtual Customer025 Customer025 { get; set; }
        public virtual ICollection<OrderLine025> OrderLine025 { get; set; }
    }
}
