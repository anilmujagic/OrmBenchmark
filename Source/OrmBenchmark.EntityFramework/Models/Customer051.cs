using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer051
    {
        public Customer051()
        {
            this.Order051 = new List<Order051>();
        }

        public string Customer051ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order051> Order051 { get; set; }
    }
}
