using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer003
    {
        public Customer003()
        {
            this.Order003 = new List<Order003>();
        }

        public string Customer003ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order003> Order003 { get; set; }
    }
}
