using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer007
    {
        public Customer007()
        {
            this.Order007 = new List<Order007>();
        }

        public string Customer007ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order007> Order007 { get; set; }
    }
}
