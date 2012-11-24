using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer055
    {
        public Customer055()
        {
            this.Order055 = new List<Order055>();
        }

        public string Customer055ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order055> Order055 { get; set; }
    }
}
