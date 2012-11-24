using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer060
    {
        public Customer060()
        {
            this.Order060 = new List<Order060>();
        }

        public string Customer060ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order060> Order060 { get; set; }
    }
}
