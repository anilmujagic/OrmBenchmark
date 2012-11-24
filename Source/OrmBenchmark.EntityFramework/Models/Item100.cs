using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item100
    {
        public Item100()
        {
            this.OrderLine100 = new List<OrderLine100>();
        }

        public string Item100ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine100> OrderLine100 { get; set; }
    }
}
