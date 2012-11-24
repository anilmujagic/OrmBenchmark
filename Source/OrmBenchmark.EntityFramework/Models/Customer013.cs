using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer013
    {
        public Customer013()
        {
            this.Order013 = new List<Order013>();
        }

        public string Customer013ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order013> Order013 { get; set; }
    }
}
