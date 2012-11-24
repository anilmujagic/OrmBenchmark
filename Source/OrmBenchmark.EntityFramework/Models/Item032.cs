using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item032
    {
        public Item032()
        {
            this.OrderLine032 = new List<OrderLine032>();
        }

        public string Item032ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine032> OrderLine032 { get; set; }
    }
}
