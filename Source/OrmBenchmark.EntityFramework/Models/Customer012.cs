using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer012
    {
        public Customer012()
        {
            this.Order012 = new List<Order012>();
        }

        public string Customer012ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order012> Order012 { get; set; }
    }
}
