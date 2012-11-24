using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer077
    {
        public Customer077()
        {
            this.Order077 = new List<Order077>();
        }

        public string Customer077ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order077> Order077 { get; set; }
    }
}
