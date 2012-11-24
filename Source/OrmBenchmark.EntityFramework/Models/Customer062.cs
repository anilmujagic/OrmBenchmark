using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer062
    {
        public Customer062()
        {
            this.Order062 = new List<Order062>();
        }

        public string Customer062ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order062> Order062 { get; set; }
    }
}
