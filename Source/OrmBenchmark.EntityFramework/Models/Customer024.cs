using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer024
    {
        public Customer024()
        {
            this.Order024 = new List<Order024>();
        }

        public string Customer024ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order024> Order024 { get; set; }
    }
}
