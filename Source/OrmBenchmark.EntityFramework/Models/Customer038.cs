using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer038
    {
        public Customer038()
        {
            this.Order038 = new List<Order038>();
        }

        public string Customer038ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order038> Order038 { get; set; }
    }
}
