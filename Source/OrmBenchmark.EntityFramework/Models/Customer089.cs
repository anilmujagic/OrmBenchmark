using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer089
    {
        public Customer089()
        {
            this.Order089 = new List<Order089>();
        }

        public string Customer089ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order089> Order089 { get; set; }
    }
}
