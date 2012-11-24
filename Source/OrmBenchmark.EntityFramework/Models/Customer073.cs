using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer073
    {
        public Customer073()
        {
            this.Order073 = new List<Order073>();
        }

        public string Customer073ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order073> Order073 { get; set; }
    }
}
