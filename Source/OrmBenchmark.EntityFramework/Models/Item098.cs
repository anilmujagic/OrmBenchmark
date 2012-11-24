using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item098
    {
        public Item098()
        {
            this.OrderLine098 = new List<OrderLine098>();
        }

        public string Item098ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine098> OrderLine098 { get; set; }
    }
}
