using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item092
    {
        public Item092()
        {
            this.OrderLine092 = new List<OrderLine092>();
        }

        public string Item092ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine092> OrderLine092 { get; set; }
    }
}
