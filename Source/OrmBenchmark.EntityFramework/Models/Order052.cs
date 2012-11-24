using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order052
    {
        public Order052()
        {
            this.OrderLine052 = new List<OrderLine052>();
        }

        public int Order052ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer052ID { get; set; }
        public string Note { get; set; }
        public virtual Customer052 Customer052 { get; set; }
        public virtual ICollection<OrderLine052> OrderLine052 { get; set; }
    }
}
