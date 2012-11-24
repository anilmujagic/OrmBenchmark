using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer036
    {
        public Customer036()
        {
            this.Order036 = new List<Order036>();
        }

        public string Customer036ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order036> Order036 { get; set; }
    }
}
