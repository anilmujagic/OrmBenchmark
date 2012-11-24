using System;
using System.Collections.Generic;

namespace OrmBenchmark.EntityFramework.Models
{
    public class Item052
    {
        public Item052()
        {
            this.OrderLine052 = new List<OrderLine052>();
        }

        public string Item052ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<OrderLine052> OrderLine052 { get; set; }
    }
}
