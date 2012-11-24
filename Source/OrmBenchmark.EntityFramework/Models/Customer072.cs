using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer072
    {
        public Customer072()
        {
            this.Order072 = new List<Order072>();
        }

        public string Customer072ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order072> Order072 { get; set; }
    }
}
