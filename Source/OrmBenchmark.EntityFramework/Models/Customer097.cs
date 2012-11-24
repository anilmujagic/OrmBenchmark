using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer097
    {
        public Customer097()
        {
            this.Order097 = new List<Order097>();
        }

        public string Customer097ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order097> Order097 { get; set; }
    }
}
