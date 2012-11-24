using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer005
    {
        public Customer005()
        {
            this.Order005 = new List<Order005>();
        }

        public string Customer005ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order005> Order005 { get; set; }
    }
}
