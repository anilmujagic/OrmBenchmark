using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer065
    {
        public Customer065()
        {
            this.Order065 = new List<Order065>();
        }

        public string Customer065ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order065> Order065 { get; set; }
    }
}
