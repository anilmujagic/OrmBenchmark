using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item084
    {
        public Item084()
        {
            this.OrderLine084 = new List<OrderLine084>();
        }

        public string Item084ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine084> OrderLine084 { get; set; }
    }
}
