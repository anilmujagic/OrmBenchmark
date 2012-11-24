using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer080
    {
        public Customer080()
        {
            this.Order080 = new List<Order080>();
        }

        public string Customer080ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order080> Order080 { get; set; }
    }
}
