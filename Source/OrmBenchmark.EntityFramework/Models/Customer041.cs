using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer041
    {
        public Customer041()
        {
            this.Order041 = new List<Order041>();
        }

        public string Customer041ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order041> Order041 { get; set; }
    }
}
