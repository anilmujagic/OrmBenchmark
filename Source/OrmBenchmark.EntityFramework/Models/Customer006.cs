using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer006
    {
        public Customer006()
        {
            this.Order006 = new List<Order006>();
        }

        public string Customer006ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order006> Order006 { get; set; }
    }
}
