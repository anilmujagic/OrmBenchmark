using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item060
    {
        public Item060()
        {
            this.OrderLine060 = new List<OrderLine060>();
        }

        public string Item060ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine060> OrderLine060 { get; set; }
    }
}
