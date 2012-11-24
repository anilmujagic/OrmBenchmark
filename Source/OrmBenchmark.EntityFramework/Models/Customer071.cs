using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer071
    {
        public Customer071()
        {
            this.Order071 = new List<Order071>();
        }

        public string Customer071ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order071> Order071 { get; set; }
    }
}
