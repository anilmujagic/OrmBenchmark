using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item025
    {
        public Item025()
        {
            this.OrderLine025 = new List<OrderLine025>();
        }

        public string Item025ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine025> OrderLine025 { get; set; }
    }
}
