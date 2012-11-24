using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer046
    {
        public Customer046()
        {
            this.Order046 = new List<Order046>();
        }

        public string Customer046ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order046> Order046 { get; set; }
    }
}
