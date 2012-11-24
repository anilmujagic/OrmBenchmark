using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer083
    {
        public Customer083()
        {
            this.Order083 = new List<Order083>();
        }

        public string Customer083ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order083> Order083 { get; set; }
    }
}
