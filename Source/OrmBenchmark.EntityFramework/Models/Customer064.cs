using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer064
    {
        public Customer064()
        {
            this.Order064 = new List<Order064>();
        }

        public string Customer064ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order064> Order064 { get; set; }
    }
}
