using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order051
    {
        public Order051()
        {
            this.OrderLine051 = new List<OrderLine051>();
        }

        public int Order051ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer051ID { get; set; }
        public string Note { get; set; }
        public virtual Customer051 Customer051 { get; set; }
        public virtual ICollection<OrderLine051> OrderLine051 { get; set; }
    }
}
