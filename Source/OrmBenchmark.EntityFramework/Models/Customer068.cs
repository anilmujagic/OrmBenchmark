using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer068
    {
        public Customer068()
        {
            this.Order068 = new List<Order068>();
        }

        public string Customer068ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order068> Order068 { get; set; }
    }
}
