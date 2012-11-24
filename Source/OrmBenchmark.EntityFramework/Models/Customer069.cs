using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer069
    {
        public Customer069()
        {
            this.Order069 = new List<Order069>();
        }

        public string Customer069ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order069> Order069 { get; set; }
    }
}
