using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer078
    {
        public Customer078()
        {
            this.Order078 = new List<Order078>();
        }

        public string Customer078ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order078> Order078 { get; set; }
    }
}
