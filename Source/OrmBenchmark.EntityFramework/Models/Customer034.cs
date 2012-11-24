using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Customer034
    {
        public Customer034()
        {
            this.Order034 = new List<Order034>();
        }

        public string Customer034ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Order034> Order034 { get; set; }
    }
}
