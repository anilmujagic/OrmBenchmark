using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer018
    {
        public Customer018()
        {
            this.Order018 = new List<Order018>();
        }

        public string Customer018ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order018> Order018 { get; set; }
    }
}
