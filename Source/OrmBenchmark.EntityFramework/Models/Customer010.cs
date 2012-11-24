using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer010
    {
        public Customer010()
        {
            this.Order010 = new List<Order010>();
        }

        public string Customer010ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order010> Order010 { get; set; }
    }
}
