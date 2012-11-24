using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer049
    {
        public Customer049()
        {
            this.Order049 = new List<Order049>();
        }

        public string Customer049ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order049> Order049 { get; set; }
    }
}
