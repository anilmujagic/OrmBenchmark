using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer079
    {
        public Customer079()
        {
            this.Order079 = new List<Order079>();
        }

        public string Customer079ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order079> Order079 { get; set; }
    }
}
