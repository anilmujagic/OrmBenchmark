using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item053
    {
        public Item053()
        {
            this.OrderLine053 = new List<OrderLine053>();
        }

        public string Item053ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine053> OrderLine053 { get; set; }
    }
}
