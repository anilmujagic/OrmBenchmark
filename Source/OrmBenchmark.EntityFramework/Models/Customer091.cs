using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer091
    {
        public Customer091()
        {
            this.Order091 = new List<Order091>();
        }

        public string Customer091ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order091> Order091 { get; set; }
    }
}
