using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer017
    {
        public Customer017()
        {
            this.Order017 = new List<Order017>();
        }

        public string Customer017ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order017> Order017 { get; set; }
    }
}
