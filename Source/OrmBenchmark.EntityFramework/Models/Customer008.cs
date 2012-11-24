using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer008
    {
        public Customer008()
        {
            this.Order008 = new List<Order008>();
        }

        public string Customer008ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order008> Order008 { get; set; }
    }
}
