using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer096
    {
        public Customer096()
        {
            this.Order096 = new List<Order096>();
        }

        public string Customer096ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order096> Order096 { get; set; }
    }
}
