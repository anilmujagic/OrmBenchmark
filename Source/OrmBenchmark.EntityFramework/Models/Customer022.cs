using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer022
    {
        public Customer022()
        {
            this.Order022 = new List<Order022>();
        }

        public string Customer022ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order022> Order022 { get; set; }
    }
}
