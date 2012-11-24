using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer032
    {
        public Customer032()
        {
            this.Order032 = new List<Order032>();
        }

        public string Customer032ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order032> Order032 { get; set; }
    }
}
