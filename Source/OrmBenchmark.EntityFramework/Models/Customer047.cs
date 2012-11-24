using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer047
    {
        public Customer047()
        {
            this.Order047 = new List<Order047>();
        }

        public string Customer047ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order047> Order047 { get; set; }
    }
}
