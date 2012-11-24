using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer100
    {
        public Customer100()
        {
            this.Order100 = new List<Order100>();
        }

        public string Customer100ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order100> Order100 { get; set; }
    }
}
