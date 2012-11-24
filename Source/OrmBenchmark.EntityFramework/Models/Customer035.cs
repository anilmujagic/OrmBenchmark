using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer035
    {
        public Customer035()
        {
            this.Order035 = new List<Order035>();
        }

        public string Customer035ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order035> Order035 { get; set; }
    }
}
