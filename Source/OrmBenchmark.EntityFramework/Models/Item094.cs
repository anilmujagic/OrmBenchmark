using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item094
    {
        public Item094()
        {
            this.OrderLine094 = new List<OrderLine094>();
        }

        public string Item094ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine094> OrderLine094 { get; set; }
    }
}
