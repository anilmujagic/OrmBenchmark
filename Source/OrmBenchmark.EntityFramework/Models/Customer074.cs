using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer074
    {
        public Customer074()
        {
            this.Order074 = new List<Order074>();
        }

        public string Customer074ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order074> Order074 { get; set; }
    }
}
