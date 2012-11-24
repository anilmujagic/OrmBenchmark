using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item056
    {
        public Item056()
        {
            this.OrderLine056 = new List<OrderLine056>();
        }

        public string Item056ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine056> OrderLine056 { get; set; }
    }
}
