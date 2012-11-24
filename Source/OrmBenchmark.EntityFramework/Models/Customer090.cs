using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer090
    {
        public Customer090()
        {
            this.Order090 = new List<Order090>();
        }

        public string Customer090ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order090> Order090 { get; set; }
    }
}
