using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer037
    {
        public Customer037()
        {
            this.Order037 = new List<Order037>();
        }

        public string Customer037ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order037> Order037 { get; set; }
    }
}
