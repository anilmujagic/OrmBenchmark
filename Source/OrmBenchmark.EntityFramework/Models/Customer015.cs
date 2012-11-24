using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer015
    {
        public Customer015()
        {
            this.Order015 = new List<Order015>();
        }

        public string Customer015ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order015> Order015 { get; set; }
    }
}
