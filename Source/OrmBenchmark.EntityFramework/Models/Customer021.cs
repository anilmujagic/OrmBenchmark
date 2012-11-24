using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer021
    {
        public Customer021()
        {
            this.Order021 = new List<Order021>();
        }

        public string Customer021ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order021> Order021 { get; set; }
    }
}
