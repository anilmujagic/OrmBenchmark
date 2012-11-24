using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer043
    {
        public Customer043()
        {
            this.Order043 = new List<Order043>();
        }

        public string Customer043ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order043> Order043 { get; set; }
    }
}
