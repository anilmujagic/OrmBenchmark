using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer061
    {
        public Customer061()
        {
            this.Order061 = new List<Order061>();
        }

        public string Customer061ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order061> Order061 { get; set; }
    }
}
