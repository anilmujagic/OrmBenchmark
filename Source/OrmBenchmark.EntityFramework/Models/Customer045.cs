using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer045
    {
        public Customer045()
        {
            this.Order045 = new List<Order045>();
        }

        public string Customer045ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order045> Order045 { get; set; }
    }
}
