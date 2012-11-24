using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item057
    {
        public Item057()
        {
            this.OrderLine057 = new List<OrderLine057>();
        }

        public string Item057ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine057> OrderLine057 { get; set; }
    }
}
