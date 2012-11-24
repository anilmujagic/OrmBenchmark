using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer057
    {
        public Customer057()
        {
            this.Order057 = new List<Order057>();
        }

        public string Customer057ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order057> Order057 { get; set; }
    }
}
