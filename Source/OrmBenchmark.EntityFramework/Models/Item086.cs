using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item086
    {
        public Item086()
        {
            this.OrderLine086 = new List<OrderLine086>();
        }

        public string Item086ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine086> OrderLine086 { get; set; }
    }
}
