using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order003
    {
        public Order003()
        {
            this.OrderLine003 = new List<OrderLine003>();
        }

        public int Order003ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer003ID { get; set; }
        public string Note { get; set; }
        public virtual Customer003 Customer003 { get; set; }
        public virtual ICollection<OrderLine003> OrderLine003 { get; set; }
    }
}
