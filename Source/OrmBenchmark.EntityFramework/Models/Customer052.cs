using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer052
    {
        public Customer052()
        {
            this.Order052 = new List<Order052>();
        }

        public string Customer052ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order052> Order052 { get; set; }
    }
}
