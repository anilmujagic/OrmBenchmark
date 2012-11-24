using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item017
    {
        public Item017()
        {
            this.OrderLine017 = new List<OrderLine017>();
        }

        public string Item017ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine017> OrderLine017 { get; set; }
    }
}
