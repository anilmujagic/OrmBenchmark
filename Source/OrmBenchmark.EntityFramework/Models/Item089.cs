using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item089
    {
        public Item089()
        {
            this.OrderLine089 = new List<OrderLine089>();
        }

        public string Item089ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine089> OrderLine089 { get; set; }
    }
}
