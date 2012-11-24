using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer076
    {
        public Customer076()
        {
            this.Order076 = new List<Order076>();
        }

        public string Customer076ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order076> Order076 { get; set; }
    }
}
