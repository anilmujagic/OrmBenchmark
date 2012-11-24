using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer093
    {
        public Customer093()
        {
            this.Order093 = new List<Order093>();
        }

        public string Customer093ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order093> Order093 { get; set; }
    }
}
