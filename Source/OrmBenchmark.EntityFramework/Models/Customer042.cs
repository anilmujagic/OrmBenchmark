using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer042
    {
        public Customer042()
        {
            this.Order042 = new List<Order042>();
        }

        public string Customer042ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order042> Order042 { get; set; }
    }
}
