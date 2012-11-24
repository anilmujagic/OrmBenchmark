using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer053
    {
        public Customer053()
        {
            this.Order053 = new List<Order053>();
        }

        public string Customer053ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order053> Order053 { get; set; }
    }
}
