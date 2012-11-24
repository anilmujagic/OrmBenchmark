using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer014
    {
        public Customer014()
        {
            this.Order014 = new List<Order014>();
        }

        public string Customer014ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order014> Order014 { get; set; }
    }
}
