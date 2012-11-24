using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer040
    {
        public Customer040()
        {
            this.Order040 = new List<Order040>();
        }

        public string Customer040ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order040> Order040 { get; set; }
    }
}
