using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item058
    {
        public Item058()
        {
            this.OrderLine058 = new List<OrderLine058>();
        }

        public string Item058ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine058> OrderLine058 { get; set; }
    }
}
