using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer088
    {
        public Customer088()
        {
            this.Order088 = new List<Order088>();
        }

        public string Customer088ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order088> Order088 { get; set; }
    }
}
