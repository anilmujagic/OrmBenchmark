using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer029
    {
        public Customer029()
        {
            this.Order029 = new List<Order029>();
        }

        public string Customer029ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order029> Order029 { get; set; }
    }
}
