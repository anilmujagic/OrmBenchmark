using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer002
    {
        public Customer002()
        {
            this.Order002 = new List<Order002>();
        }

        public string Customer002ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order002> Order002 { get; set; }
    }
}
