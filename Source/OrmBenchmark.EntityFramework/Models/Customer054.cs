using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer054
    {
        public Customer054()
        {
            this.Order054 = new List<Order054>();
        }

        public string Customer054ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order054> Order054 { get; set; }
    }
}
