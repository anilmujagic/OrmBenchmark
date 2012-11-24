using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer027
    {
        public Customer027()
        {
            this.Order027 = new List<Order027>();
        }

        public string Customer027ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order027> Order027 { get; set; }
    }
}
