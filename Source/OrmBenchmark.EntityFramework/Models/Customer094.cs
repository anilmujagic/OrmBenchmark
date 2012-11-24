using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer094
    {
        public Customer094()
        {
            this.Order094 = new List<Order094>();
        }

        public string Customer094ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order094> Order094 { get; set; }
    }
}
