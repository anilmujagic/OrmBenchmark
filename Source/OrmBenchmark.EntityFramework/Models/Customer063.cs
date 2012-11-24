using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer063
    {
        public Customer063()
        {
            this.Order063 = new List<Order063>();
        }

        public string Customer063ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order063> Order063 { get; set; }
    }
}
