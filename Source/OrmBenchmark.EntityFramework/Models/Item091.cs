using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item091
    {
        public Item091()
        {
            this.OrderLine091 = new List<OrderLine091>();
        }

        public string Item091ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine091> OrderLine091 { get; set; }
    }
}
