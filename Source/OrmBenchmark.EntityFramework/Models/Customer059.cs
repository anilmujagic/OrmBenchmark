using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer059
    {
        public Customer059()
        {
            this.Order059 = new List<Order059>();
        }

        public string Customer059ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order059> Order059 { get; set; }
    }
}
