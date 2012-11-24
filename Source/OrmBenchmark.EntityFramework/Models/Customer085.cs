using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer085
    {
        public Customer085()
        {
            this.Order085 = new List<Order085>();
        }

        public string Customer085ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order085> Order085 { get; set; }
    }
}
