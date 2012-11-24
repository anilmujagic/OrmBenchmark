using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer033
    {
        public Customer033()
        {
            this.Order033 = new List<Order033>();
        }

        public string Customer033ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order033> Order033 { get; set; }
    }
}
