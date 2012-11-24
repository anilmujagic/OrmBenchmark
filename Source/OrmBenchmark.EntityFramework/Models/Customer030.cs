using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer030
    {
        public Customer030()
        {
            this.Order030 = new List<Order030>();
        }

        public string Customer030ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order030> Order030 { get; set; }
    }
}
