using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer011
    {
        public Customer011()
        {
            this.Order011 = new List<Order011>();
        }

        public string Customer011ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order011> Order011 { get; set; }
    }
}
