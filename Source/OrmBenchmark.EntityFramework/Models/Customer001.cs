using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer001
    {
        public Customer001()
        {
            this.Order001 = new List<Order001>();
        }

        public string Customer001ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order001> Order001 { get; set; }
    }
}
