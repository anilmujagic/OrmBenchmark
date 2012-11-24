using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer081
    {
        public Customer081()
        {
            this.Order081 = new List<Order081>();
        }

        public string Customer081ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order081> Order081 { get; set; }
    }
}
