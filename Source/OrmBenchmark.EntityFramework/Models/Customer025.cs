using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer025
    {
        public Customer025()
        {
            this.Order025 = new List<Order025>();
        }

        public string Customer025ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order025> Order025 { get; set; }
    }
}
