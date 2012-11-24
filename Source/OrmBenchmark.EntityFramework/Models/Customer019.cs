using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer019
    {
        public Customer019()
        {
            this.Order019 = new List<Order019>();
        }

        public string Customer019ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order019> Order019 { get; set; }
    }
}
