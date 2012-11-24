using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item037
    {
        public Item037()
        {
            this.OrderLine037 = new List<OrderLine037>();
        }

        public string Item037ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine037> OrderLine037 { get; set; }
    }
}
