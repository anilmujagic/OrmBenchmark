using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer048
    {
        public Customer048()
        {
            this.Order048 = new List<Order048>();
        }

        public string Customer048ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order048> Order048 { get; set; }
    }
}
