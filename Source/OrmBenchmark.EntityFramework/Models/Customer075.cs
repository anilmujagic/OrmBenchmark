using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer075
    {
        public Customer075()
        {
            this.Order075 = new List<Order075>();
        }

        public string Customer075ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order075> Order075 { get; set; }
    }
}
