using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer050
    {
        public Customer050()
        {
            this.Order050 = new List<Order050>();
        }

        public string Customer050ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order050> Order050 { get; set; }
    }
}
