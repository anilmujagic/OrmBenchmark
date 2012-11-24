using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer031
    {
        public Customer031()
        {
            this.Order031 = new List<Order031>();
        }

        public string Customer031ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order031> Order031 { get; set; }
    }
}
