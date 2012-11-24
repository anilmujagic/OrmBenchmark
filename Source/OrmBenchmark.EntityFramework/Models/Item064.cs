using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item064
    {
        public Item064()
        {
            this.OrderLine064 = new List<OrderLine064>();
        }

        public string Item064ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine064> OrderLine064 { get; set; }
    }
}
