using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer009
    {
        public Customer009()
        {
            this.Order009 = new List<Order009>();
        }

        public string Customer009ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order009> Order009 { get; set; }
    }
}
