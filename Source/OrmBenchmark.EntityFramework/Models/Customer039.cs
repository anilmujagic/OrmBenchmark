using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer039
    {
        public Customer039()
        {
            this.Order039 = new List<Order039>();
        }

        public string Customer039ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order039> Order039 { get; set; }
    }
}
