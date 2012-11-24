using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer044
    {
        public Customer044()
        {
            this.Order044 = new List<Order044>();
        }

        public string Customer044ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order044> Order044 { get; set; }
    }
}
