using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer092
    {
        public Customer092()
        {
            this.Order092 = new List<Order092>();
        }

        public string Customer092ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order092> Order092 { get; set; }
    }
}
