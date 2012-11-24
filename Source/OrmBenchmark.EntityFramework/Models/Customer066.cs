using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer066
    {
        public Customer066()
        {
            this.Order066 = new List<Order066>();
        }

        public string Customer066ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order066> Order066 { get; set; }
    }
}
