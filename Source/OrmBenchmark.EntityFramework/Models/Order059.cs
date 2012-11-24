using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Order059
    {
        public Order059()
        {
            this.OrderLine059 = new List<OrderLine059>();
        }

        public int Order059ID { get; set; }
        public System.DateTime PostingDate { get; set; }
        public string Customer059ID { get; set; }
        public string Note { get; set; }
        public virtual Customer059 Customer059 { get; set; }
        public virtual ICollection<OrderLine059> OrderLine059 { get; set; }
    }
}
