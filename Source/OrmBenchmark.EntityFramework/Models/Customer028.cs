using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer028
    {
        public Customer028()
        {
            this.Order028 = new List<Order028>();
        }

        public string Customer028ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order028> Order028 { get; set; }
    }
}
