using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer087
    {
        public Customer087()
        {
            this.Order087 = new List<Order087>();
        }

        public string Customer087ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order087> Order087 { get; set; }
    }
}
