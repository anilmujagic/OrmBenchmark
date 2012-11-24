using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer020
    {
        public Customer020()
        {
            this.Order020 = new List<Order020>();
        }

        public string Customer020ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order020> Order020 { get; set; }
    }
}
