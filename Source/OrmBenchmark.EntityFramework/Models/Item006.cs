using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item006
    {
        public Item006()
        {
            this.OrderLine006 = new List<OrderLine006>();
        }

        public string Item006ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine006> OrderLine006 { get; set; }
    }
}
