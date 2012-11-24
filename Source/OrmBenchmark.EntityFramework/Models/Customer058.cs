using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer058
    {
        public Customer058()
        {
            this.Order058 = new List<Order058>();
        }

        public string Customer058ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order058> Order058 { get; set; }
    }
}
