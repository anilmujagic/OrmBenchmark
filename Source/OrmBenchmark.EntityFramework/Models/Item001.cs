using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item001
    {
        public Item001()
        {
            this.OrderLine001 = new List<OrderLine001>();
        }

        public string Item001ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine001> OrderLine001 { get; set; }
    }
}
