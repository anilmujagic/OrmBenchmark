using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer086
    {
        public Customer086()
        {
            this.Order086 = new List<Order086>();
        }

        public string Customer086ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order086> Order086 { get; set; }
    }
}
