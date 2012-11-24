using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer098
    {
        public Customer098()
        {
            this.Order098 = new List<Order098>();
        }

        public string Customer098ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order098> Order098 { get; set; }
    }
}
