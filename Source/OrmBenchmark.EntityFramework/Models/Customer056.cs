using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer056
    {
        public Customer056()
        {
            this.Order056 = new List<Order056>();
        }

        public string Customer056ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order056> Order056 { get; set; }
    }
}
