using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer026
    {
        public Customer026()
        {
            this.Order026 = new List<Order026>();
        }

        public string Customer026ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order026> Order026 { get; set; }
    }
}
