using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer084
    {
        public Customer084()
        {
            this.Order084 = new List<Order084>();
        }

        public string Customer084ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order084> Order084 { get; set; }
    }
}
