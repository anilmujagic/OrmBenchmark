using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer004
    {
        public Customer004()
        {
            this.Order004 = new List<Order004>();
        }

        public string Customer004ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order004> Order004 { get; set; }
    }
}
