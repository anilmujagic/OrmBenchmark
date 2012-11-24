using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer067
    {
        public Customer067()
        {
            this.Order067 = new List<Order067>();
        }

        public string Customer067ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order067> Order067 { get; set; }
    }
}
