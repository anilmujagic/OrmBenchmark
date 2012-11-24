using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer099
    {
        public Customer099()
        {
            this.Order099 = new List<Order099>();
        }

        public string Customer099ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order099> Order099 { get; set; }
    }
}
